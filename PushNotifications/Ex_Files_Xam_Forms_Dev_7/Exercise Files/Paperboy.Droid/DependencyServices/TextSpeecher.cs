using System;
using Android.Speech.Tts;
using System.Collections.Generic;
using Xamarin.Forms;
using Paperboy.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(TextSpeecher))]
namespace Paperboy.Droid
    {
        public class TextSpeecher : Java.Lang.Object, ITextSpeecher, TextToSpeech.IOnInitListener
        {
            TextToSpeech speaker;
            string toSpeak;

            public TextSpeecher() { }

            public void Speak(string text)
            {
                var ctx = Forms.Context;
                toSpeak = text;
                if (speaker == null)
                {
                    speaker = new TextToSpeech(ctx, this);
                }
                else
                {
                    if (Android.OS.Build.VERSION.Release.StartsWith("4"))
                    {
                        speaker.Speak(toSpeak, QueueMode.Flush, null);
                    }
                    else
                    {
                        speaker.Speak(toSpeak, QueueMode.Flush, null, null);
                    }
                }
            }

            #region IOnInitListener implementation
            public void OnInit(OperationResult status)
            {
                if (status.Equals(OperationResult.Success))
                {
                    if (Android.OS.Build.VERSION.Release.StartsWith("4"))
                    {
                        speaker.Speak(toSpeak, QueueMode.Flush, null);
                    }
                    else
                    {
                        speaker.Speak(toSpeak, QueueMode.Flush, null, null);
                    }
                }
            }
            #endregion
        }
    }