using System;
using System.Collections.Generic;
using System.Text;

namespace SAPBlazorAnimate.Models
{
    #region Attention Seekers
    public class SAPAttentionSeekersGroup
    {
        public AnimateType Bounce => AnimateType.bounce;
        public AnimateType Flash => AnimateType.flash;
        public AnimateType Pulse => AnimateType.pulse;
        public AnimateType RubberBand => AnimateType.rubberBand;
        public AnimateType Shake => AnimateType.shake;
        public AnimateType Swing => AnimateType.swing;
        public AnimateType Tada => AnimateType.tada;
        public AnimateType Wobble => AnimateType.wobble;
        public AnimateType Jello => AnimateType.jello;
        public AnimateType HeartBeat => AnimateType.heartBeat;
    }
    #endregion

    #region Bouncing Entrances
    public class SAPBouncingEntrancesGroup
    {
        public AnimateType BounceIn => AnimateType.bounceIn;
        public AnimateType BounceInDown => AnimateType.bounceInDown;
        public AnimateType BounceInLeft => AnimateType.bounceInLeft;
        public AnimateType BounceInRight => AnimateType.bounceInRight;
        public AnimateType BounceInUp => AnimateType.bounceInUp;

    }
    #endregion

    #region Bouncing Exits
    public class SAPBouncingExitsGroup
    {
        public AnimateType BounceOut => AnimateType.bounceOut;
        public AnimateType BounceOutDown => AnimateType.bounceOutDown;
        public AnimateType BounceOutLeft => AnimateType.bounceOutLeft;
        public AnimateType BounceOutRight => AnimateType.bounceOutRight;
        public AnimateType BounceOutUp => AnimateType.bounceOutUp;

    }
    #endregion

    #region Fading Entrances
    public class SAPFadingEntrancesGroup
    {
        public AnimateType FadeIn => AnimateType.fadeIn;
        public AnimateType FadeInDown => AnimateType.fadeInDown;
        public AnimateType FadeInDownBig => AnimateType.fadeInDownBig;
        public AnimateType FadeInLeft => AnimateType.fadeInLeft;
        public AnimateType FadeInLeftBig => AnimateType.fadeInLeftBig;
        public AnimateType FadeInRight => AnimateType.fadeInRight;
        public AnimateType FadeInRightBig => AnimateType.fadeInRightBig;
        public AnimateType FadeInUp => AnimateType.fadeInUp;
        public AnimateType FadeInUpBig => AnimateType.fadeInUpBig;


    }
    #endregion

    #region Fading Exits
    public class SAPFadingExitsGroup
    {
        public AnimateType FadeOut => AnimateType.fadeOut;
        public AnimateType FadeOutDown => AnimateType.fadeOutDown;
        public AnimateType FadeOutDownBig => AnimateType.fadeOutDownBig;
        public AnimateType FadeOutLeft => AnimateType.fadeOutLeft;
        public AnimateType FadeOutLeftBig => AnimateType.fadeOutLeftBig;
        public AnimateType FadeOutRight => AnimateType.fadeOutRight;
        public AnimateType FadeOutRightBig => AnimateType.fadeOutRightBig;
        public AnimateType FadeOutUp => AnimateType.fadeOutUp;
        public AnimateType FadeOutUpBig => AnimateType.fadeOutUpBig;


    }
    #endregion

    #region Flippers
    public class SAPFlippersGroup
    {
        public AnimateType Flip => AnimateType.flip;
        public AnimateType FlipInX => AnimateType.flipInX;
        public AnimateType FlipInY => AnimateType.flipInY;
        public AnimateType FlipOutX => AnimateType.flipOutX;
        public AnimateType FlipOutY => AnimateType.flipOutY;



    }
    #endregion

    #region Light Speed
    public class SAPLightspeedGroup
    {
        public AnimateType LightSpeedIn => AnimateType.lightSpeedIn;
        public AnimateType LightSpeedOut => AnimateType.lightSpeedOut;




    }
    #endregion

    #region Rotating Entrances
    public class SAPRotatingEntrancesGroup
    {
        public AnimateType RotateIn => AnimateType.rotateIn;
        public AnimateType RotateInDownLeft => AnimateType.rotateInDownLeft;
        public AnimateType RotateInDownRight => AnimateType.rotateInDownRight;
        public AnimateType RotateInUpLeft => AnimateType.rotateInUpLeft;
        public AnimateType RotateInUpRight => AnimateType.rotateInUpRight;



    }
    #endregion

    #region Rotating Exits
    public class SAPRotatingExitsGroup
    {
        public AnimateType RotateOut => AnimateType.rotateOut;
        public AnimateType RotateOutDownLeft => AnimateType.rotateOutDownLeft;
        public AnimateType RotateOutDownRight => AnimateType.rotateOutDownRight;
        public AnimateType RotateOutUpLeft => AnimateType.rotateOutUpLeft;
        public AnimateType RotateOutUpRight => AnimateType.rotateOutUpRight;



    }
    #endregion

    #region Sliding Entrances
    public class SAPSlidingEntrancesGroup
    {
        public AnimateType SlideInUp => AnimateType.slideInUp;
        public AnimateType SlideInDown => AnimateType.slideInDown;
        public AnimateType SlideInLeft => AnimateType.slideInLeft;
        public AnimateType SlideInRight => AnimateType.slideInRight;



    }
    #endregion

    #region Sliding Exits
    public class SAPSlidingExitsGroup
    {
        public AnimateType SlideOutUp => AnimateType.slideOutUp;
        public AnimateType SlideOutDown => AnimateType.slideOutDown;
        public AnimateType SlideOutLeft => AnimateType.slideOutLeft;
        public AnimateType SlideOutRight => AnimateType.slideOutRight;



    }
    #endregion

    #region Zoom Entrances
    public class SAPZoomEntrancesGroup
    {
        public AnimateType ZoomIn => AnimateType.zoomIn;
        public AnimateType ZoomInDown => AnimateType.zoomInDown;
        public AnimateType ZoomInLeft => AnimateType.zoomInLeft;
        public AnimateType ZoomInRight => AnimateType.zoomInRight;
        public AnimateType ZoomInUp => AnimateType.zoomInUp;



    }
    #endregion

    #region Zoom Exits
    public class SAPZoomExitsGroup
    {
        public AnimateType ZoomOut => AnimateType.zoomOut;
        public AnimateType ZoomOutDown => AnimateType.zoomOutDown;
        public AnimateType ZoomOutLeft => AnimateType.zoomOutLeft;
        public AnimateType ZoomOutRight => AnimateType.zoomOutRight;
        public AnimateType ZoomOutUp => AnimateType.zoomOutUp;



    }
    #endregion

    #region Specials
    public class SAPSpecialsGroup
    {
        public AnimateType Hinge => AnimateType.hinge;
        public AnimateType JackInTheBox => AnimateType.jackInTheBox;
        public AnimateType RollIn => AnimateType.rollIn;
        public AnimateType RollOut => AnimateType.rollOut;



    }
    #endregion

}
