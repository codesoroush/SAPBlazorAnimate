using SAPBlazorAnimate.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SAPBlazorAnimate
{
    public static class AnimateBook
    {
        /// <summary>
        /// Those who are seeking attention
        /// </summary>
        public static SAPAttentionSeekersGroup AttentionSeekers = new SAPAttentionSeekersGroup();
        public static SAPBouncingEntrancesGroup BouncingEntrances = new SAPBouncingEntrancesGroup();
        public static SAPBouncingExitsGroup BouncingExits = new SAPBouncingExitsGroup();
        public static SAPFadingEntrancesGroup FadingEntrances = new SAPFadingEntrancesGroup();
        public static SAPFadingExitsGroup FadingExits = new SAPFadingExitsGroup();
        public static SAPFlippersGroup Flippers = new SAPFlippersGroup();
        public static SAPLightspeedGroup Lightspeed = new SAPLightspeedGroup();
        public static SAPRotatingEntrancesGroup RotatingEntrances = new SAPRotatingEntrancesGroup();
        public static SAPRotatingExitsGroup RotatingExits = new SAPRotatingExitsGroup();
        public static SAPSlidingEntrancesGroup SlidingEntrances = new SAPSlidingEntrancesGroup();
        public static SAPSlidingExitsGroup SlidingExits = new SAPSlidingExitsGroup();
        public static SAPZoomEntrancesGroup ZoomEntrances = new SAPZoomEntrancesGroup();
        public static SAPZoomExitsGroup ZoomExits = new SAPZoomExitsGroup();
        public static SAPSpecialsGroup Specials = new SAPSpecialsGroup();
    }
}
