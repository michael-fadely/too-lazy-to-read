﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TooLazyToRead.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TooLazyToRead.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The voice saved in the configuration (&quot;{0}&quot;)
        ///couldn&apos;t be detected. Using default..
        /// </summary>
        internal static string MainWindow_ApplySettings_ConfiguredVoiceNotFound_Message {
            get {
                return ResourceManager.GetString("MainWindow_ApplySettings_ConfiguredVoiceNotFound_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configured Voice Not Found.
        /// </summary>
        internal static string MainWindow_ApplySettings_ConfiguredVoiceNotFound_Title {
            get {
                return ResourceManager.GetString("MainWindow_ApplySettings_ConfiguredVoiceNotFound_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred loading the voice &quot;{0}&quot;:
        ///
        ///{1}.
        /// </summary>
        internal static string MainWindow_comboVoices_SelectedIndexChanged_ErrorLoadingVoice_Message {
            get {
                return ResourceManager.GetString("MainWindow_comboVoices_SelectedIndexChanged_ErrorLoadingVoice_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error loading voice.
        /// </summary>
        internal static string MainWindow_comboVoices_SelectedIndexChanged_ErrorLoadingVoice_Title {
            get {
                return ResourceManager.GetString("MainWindow_comboVoices_SelectedIndexChanged_ErrorLoadingVoice_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to exit? I&apos;m not done reading!.
        /// </summary>
        internal static string MainWindow_exitToolStripMenuItem_Click_ConfirmExit_Message {
            get {
                return ResourceManager.GetString("MainWindow_exitToolStripMenuItem_Click_ConfirmExit_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure?.
        /// </summary>
        internal static string MainWindow_exitToolStripMenuItem_Click_ConfirmExit_Title {
            get {
                return ResourceManager.GetString("MainWindow_exitToolStripMenuItem_Click_ConfirmExit_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to open clipboard. It was likely still in use by another program.
        ///Would you like to try again?.
        /// </summary>
        internal static string MainWindow_GetClipboard_OpenClipboardFailed_Message {
            get {
                return ResourceManager.GetString("MainWindow_GetClipboard_OpenClipboardFailed_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to open clipboard.
        /// </summary>
        internal static string MainWindow_GetClipboard_OpenClipboardFailed_Title {
            get {
                return ResourceManager.GetString("MainWindow_GetClipboard_OpenClipboardFailed_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while trying to save this recording.
        ///{0}.
        /// </summary>
        internal static string MainWindow_recordToWAVToolStripMenuItem_Click_ErrorSavingRecording_Message {
            get {
                return ResourceManager.GetString("MainWindow_recordToWAVToolStripMenuItem_Click_ErrorSavingRecording_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error saving recording.
        /// </summary>
        internal static string MainWindow_recordToWAVToolStripMenuItem_Click_ErrorSavingRecording_Title {
            get {
                return ResourceManager.GetString("MainWindow_recordToWAVToolStripMenuItem_Click_ErrorSavingRecording_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Recording complete! Would you like to open it now?.
        /// </summary>
        internal static string MainWindow_recordToWAVToolStripMenuItem_Click_RecordingComplete_Message {
            get {
                return ResourceManager.GetString("MainWindow_recordToWAVToolStripMenuItem_Click_RecordingComplete_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Recording saved successfully.
        /// </summary>
        internal static string MainWindow_recordToWAVToolStripMenuItem_Click_RecordingComplete_Title {
            get {
                return ResourceManager.GetString("MainWindow_recordToWAVToolStripMenuItem_Click_RecordingComplete_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while trying to run the filter:
        ///
        ///Name: {0}
        ///Type: {1}
        ///
        ///{2}.
        /// </summary>
        internal static string MainWindow_RunFilters_FilterError_Message {
            get {
                return ResourceManager.GetString("MainWindow_RunFilters_FilterError_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Filter Error.
        /// </summary>
        internal static string MainWindow_RunFilters_FilterError_Title {
            get {
                return ResourceManager.GetString("MainWindow_RunFilters_FilterError_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This file doesn&apos;t contain any filters..
        /// </summary>
        internal static string MainWindow_toolImportFilter_Click_NoFiltersInFile_Message {
            get {
                return ResourceManager.GetString("MainWindow_toolImportFilter_Click_NoFiltersInFile_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Import error.
        /// </summary>
        internal static string MainWindow_toolImportFilter_Click_NoFiltersInFile_Title {
            get {
                return ResourceManager.GetString("MainWindow_toolImportFilter_Click_NoFiltersInFile_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Voice speed ({0}).
        /// </summary>
        internal static string MainWindow_trackVoiceSpeed_Scroll_VoiceSpeedToolTip {
            get {
                return ResourceManager.GetString("MainWindow_trackVoiceSpeed_Scroll_VoiceSpeedToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon Pause {
            get {
                object obj = ResourceManager.GetObject("Pause", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Pause_PNG {
            get {
                object obj = ResourceManager.GetObject("Pause_PNG", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon Play {
            get {
                object obj = ResourceManager.GetObject("Play", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Play_PNG {
            get {
                object obj = ResourceManager.GetObject("Play_PNG", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon PlayClipboard {
            get {
                object obj = ResourceManager.GetObject("PlayClipboard", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap PlayClipboard_PNG {
            get {
                object obj = ResourceManager.GetObject("PlayClipboard_PNG", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap PlayFrom_PNG {
            get {
                object obj = ResourceManager.GetObject("PlayFrom_PNG", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon Stop {
            get {
                object obj = ResourceManager.GetObject("Stop", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Stop_PNG {
            get {
                object obj = ResourceManager.GetObject("Stop_PNG", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
