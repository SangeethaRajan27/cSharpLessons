using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.DayThree
{
    internal class MediaContents
    {
        public virtual void StartPlayingContent()
        {
            Console.WriteLine( "Start");
        }

        public void StopPlayingContent()
        {
            Console.WriteLine("Stop");
        }

        public void PausePlayingContent() 
        {
            Console.WriteLine( "Pause");
        }

        public void ContinuePlayingContent() 
        {
            Console.WriteLine("Continue");
        }

        public override sealed string ToString()
        {
            Console.WriteLine( "Media ToString");
            return "OTT";
        }
    }
    //END OF MEDIA CONTENTS
    internal class AudioContent : MediaContents
    {
        public override sealed void StartPlayingContent()
        {
            Console.WriteLine("Start");
        }

        public  string ToString()
        {
            Console.WriteLine("Media ToString");
            return "OTT";
        }

    }
    //END OF AUDIO CONTENTS

    internal class VideoContent : AudioContent
    {
        //public override  void StartPlayingContent()
        //{
        //   Console.WriteLine("Start");
        //}

    }
    //END OF VIDEO
    internal class MediaTester
    {
        public static void TestOne()
        {

        }
    }
    //END OF MEDIA TESTER
}
