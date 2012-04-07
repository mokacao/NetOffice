﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ExampleBase;

using LateBindingApi.Core;
using Word = NetOffice.WordApi;
using Office = NetOffice.OfficeApi;
using NetOffice.WordApi.Enums;
using NetOffice.OfficeApi.Enums;

namespace WordExamplesCS4
{
    public partial class Example07 : UserControl, IExample
    {        
        IHost _hostApplication;
        Word.Application _wordApplication;
        private delegate void UpdateEventTextDelegate(string Message);
        UpdateEventTextDelegate _updateDelegate;

        public Example07()
        {
            InitializeComponent();
            _updateDelegate = new UpdateEventTextDelegate(UpdateTextbox);
        }

        #region IExample Member

        public void RunExample()
        {
            // its an example with an own visual control
            // checkout buttonStartExample_Click
        }

        public void Connect(IHost hostApplication)
        {
            _hostApplication = hostApplication;
        }

        public string Caption
        {
            get { return _hostApplication.LCID == 1033 ? "Example07" : "Beispiel07"; }
        }

        public string Description
        {
            get { return _hostApplication.LCID == 1033 ? "Customize UI" : "UI Items erstellen"; }
        }

        public UserControl Panel
        {
            get { return this; }
        }

        #endregion

        #region UI Trigger

        private void buttonStartExample_Click(object sender, EventArgs e)
        {
            // Initialize NetOffice
            LateBindingApi.Core.Factory.Initialize();
            
            Office.CommandBar commandBar;
            Office.CommandBarButton commandBarBtn;

            // start word and turn off msg boxes
            _wordApplication = new Word.Application();
            _wordApplication.DisplayAlerts = WdAlertLevel.wdAlertsNone;

            // add a new document
            _wordApplication.Documents.Add();

            Word.Template normalDotTemplate = GetNormalDotTemplate();
            _wordApplication.CustomizationContext = normalDotTemplate;

            // add a commandbar popup
            Office.CommandBarPopup commandBarPopup = (Office.CommandBarPopup)_wordApplication.CommandBars["Menu Bar"].Controls.Add(MsoControlType.msoControlPopup, MsoBarPosition.msoBarTop, System.Type.Missing, 1, true);
            commandBarPopup.Caption = "commandBarPopup";

            #region few words, how to access the picture
            /*
             you can see we use an own icon via .PasteFace()
             is not possible from outside process boundaries to use the PictureProperty directly
             the reason for is IPictureDisp: http://support.microsoft.com/kb/286460/de
             its not important is early or late binding or managed or unmanaged, the behaviour is always the same
             For example, a COMAddin running as InProcServer and can access the Picture Property
            */
            #endregion

            #region CommandBarButton

            // add a button to the popup
            commandBarBtn = (Office.CommandBarButton)commandBarPopup.Controls.Add(MsoControlType.msoControlButton, System.Type.Missing, System.Type.Missing, System.Type.Missing, true);
            commandBarBtn.Style = MsoButtonStyle.msoButtonIconAndCaption;
            commandBarBtn.Caption = "commandBarButton";
            Clipboard.SetDataObject(_hostApplication.DisplayIcon.ToBitmap());
            commandBarBtn.PasteFace();
            commandBarBtn.ClickEvent += new Office.CommandBarButton_ClickEventHandler(commandBarBtn_Click);

            #endregion

            #region Create a new toolbar

            // add a new toolbar
            commandBar = _wordApplication.CommandBars.Add("MyCommandBar", MsoBarPosition.msoBarTop, false, true);
            commandBar.Visible = true;

            // add a button to the toolbar
            commandBarBtn = (Office.CommandBarButton)commandBar.Controls.Add(MsoControlType.msoControlButton, System.Type.Missing, System.Type.Missing, System.Type.Missing, true);
            commandBarBtn.Style = MsoButtonStyle.msoButtonIconAndCaption;
            commandBarBtn.Caption = "commandBarButton";
            commandBarBtn.FaceId = 3;
            commandBarBtn.ClickEvent += new Office.CommandBarButton_ClickEventHandler(commandBarBtn_Click);

            // add a dropdown box to the toolbar
            commandBarPopup = (Office.CommandBarPopup)commandBar.Controls.Add(MsoControlType.msoControlPopup, System.Type.Missing, System.Type.Missing, System.Type.Missing, true);
            commandBarPopup.Caption = "commandBarPopup";

            // add a button to the popup, we use an own icon for the button
            commandBarBtn = (Office.CommandBarButton)commandBarPopup.Controls.Add(MsoControlType.msoControlButton, System.Type.Missing, System.Type.Missing, System.Type.Missing, true);
            commandBarBtn.Style = MsoButtonStyle.msoButtonIconAndCaption;
            commandBarBtn.Caption = "commandBarButton";
            Clipboard.SetDataObject(_hostApplication.DisplayIcon.ToBitmap());
            commandBarBtn.PasteFace();
            commandBarBtn.ClickEvent += new Office.CommandBarButton_ClickEventHandler(commandBarBtn_Click);

            #endregion

            #region Create a new ContextMenu

            // add a commandbar popup
            commandBarPopup = (Office.CommandBarPopup)_wordApplication.CommandBars["Text"].Controls.Add(MsoControlType.msoControlPopup, MsoBarPosition.msoBarTop, false, 1, true);
            commandBarPopup.Caption = "commandBarPopup";

            // add a button to the popup
            commandBarBtn = (Office.CommandBarButton)commandBarPopup.Controls.Add(MsoControlType.msoControlButton, System.Type.Missing, System.Type.Missing, System.Type.Missing, true);
            commandBarBtn.Style = MsoButtonStyle.msoButtonIconAndCaption;
            commandBarBtn.Caption = "commandBarButton";
            commandBarBtn.FaceId = 9;
            commandBarBtn.ClickEvent += new Office.CommandBarButton_ClickEventHandler(commandBarBtn_Click);

            #endregion

            normalDotTemplate.Saved = true;

            // make visible & set buttons
            _wordApplication.Visible = true;
            buttonStartExample.Enabled = false;
            buttonQuitExample.Enabled = true;
        }

        private void buttonQuitExample_Click(object sender, EventArgs e)
        {
            _wordApplication.Quit();
            _wordApplication.Dispose();

            buttonStartExample.Enabled = true;
            buttonQuitExample.Enabled = false;
        }

        #endregion

        #region Word Trigger

        void commandBarBtn_Click(Office.CommandBarButton Ctrl, ref bool CancelDefault)
        {
            textBoxEvents.BeginInvoke(_updateDelegate, new object[] { "Click called." });
            Ctrl.Dispose();
        }

        private void UpdateTextbox(string Message)
        {
            textBoxEvents.AppendText(Message + "\r\n");
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// returns normal.dot template (normal.dotm in modern word versions)
        /// </summary>
        private Word.Template GetNormalDotTemplate()
        {
            foreach (Word.Template installedTemplate in _wordApplication.Templates)
            {
                if (installedTemplate.Name.StartsWith("normal", StringComparison.InvariantCultureIgnoreCase))
                {
                    return installedTemplate;
                }
                installedTemplate.Dispose();
            }

            throw new IndexOutOfRangeException("Template not found.");
        }

        #endregion
    }
}
