﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;

namespace Minista.Helpers
{
    /// <summary>
    /// When I share a photo on Instagram, what's the image resolution?
    /// 
    /// When you share a photo on Instagram, regardless of whether you're using Instagram for iOS or Android,
    /// we make sure to upload it at the best quality resolution possible (up to a width of 1080 pixels).
    /// 
    /// When you share a photo that has a width between 320 and 1080 pixels, we keep that photo at its original resolution
    /// as long as the photo's aspect ratio is between 1.91:1 and 4:5 (a height between 566 and 1350 pixels with a width of 1080 pixels)
    /// . If the aspect ratio of your photo isn't supported, it will be cropped to fit a supported ratio. If you share a photo at
    /// a lower resolution, we enlarge it to a width of 320 pixels. If you share a photo at a higher resolution, we size it down to
    /// a width of 1080 pixels.
    /// 
    /// If you want to make sure that your photo is shared with a width of 1080 pixels
    /// Upload a photo with a width of at least 1080 pixels with an aspect ratio between 1.91:1 and 4:5.
    /// Make sure you're using a phone with a high-quality camera as different phones have cameras of varying qualities.
    /// 
    /// </summary>
    class SizeHelper
    {
        const int MIN_WIDTH = 320;
        const int MAX_WIDTH = 1080;
        const int THUMBNAIL_SIZE = 292;
        public readonly List<int> Sizes = new List<int>
        {
            1080,
            1024,
            960,
            800,
            768,
            720,
            640,
            612,
            600,
            546,
            500,
            468,
            480,
            400,
            320
        };
        //int CalculateHeight(double height)
        //{

        //}

        int GetDifference(int a)
        {
            return Math.Abs(a);
        }
        void ABC()
        {

            //        var sorted =
            //Sizes
            //.OrderBy((s) => GetDifference(s.Height, someSize.Height) + GetDifference(s.Width, someSize.Width))
    //        //.ThenBy((s) => Math.Abs(GetDifference(s.Height, s.Width) - GetDifference(someSize.Height, someSize.Width)));

    //        var sorted =
    //Sizes
    //.OrderBy((s) => GetDifference(s) + GetDifference(s))
    //.ThenBy((s) => Math.Abs(GetDifference(s) - GetDifference(someSize.Height, someSize.Width)));
        }
    }
}
