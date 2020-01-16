using SAPBlazorAnimate.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SAPBlazorAnimate.Models
{
    #region Attention Seekers
    public class SAPAttentionSeekersGroup
    {
        public string Bounce => $" {AnimateType.bounce} animated ";
        public string Flash => $" {AnimateType.flash} animated ";
        public string Pulse => $" {AnimateType.pulse} animated ";
        public string RubberBand => $" {AnimateType.rubberBand} animated ";
        public string Shake => $" {AnimateType.shake} animated ";
        public string Swing => $" {AnimateType.swing} animated ";
        public string Tada => $" {AnimateType.tada} animated ";
        public string Wobble => $" {AnimateType.wobble} animated ";
        public string Jello => $" {AnimateType.jello} animated ";
        public string HeartBeat => $" {AnimateType.heartBeat} animated ";
    }
    #endregion

    #region Bouncing Entrances
    public class SAPBouncingEntrancesGroup
    {
        public string BounceIn => $" {AnimateType.bounceIn} animated ";
        public string BounceInDown => $" {AnimateType.bounceInDown} animated ";
        public string BounceInLeft => $" {AnimateType.bounceInLeft} animated ";
        public string BounceInRight => $" {AnimateType.bounceInRight} animated ";
        public string BounceInUp => $" {AnimateType.bounceInUp} animated ";

    }
    #endregion

    #region Bouncing Exits
    public class SAPBouncingExitsGroup
    {
        public string BounceOut => $" {AnimateType.bounceOut} animated ";
        public string BounceOutDown => $" {AnimateType.bounceOutDown} animated ";
        public string BounceOutLeft => $" {AnimateType.bounceOutLeft} animated ";
        public string BounceOutRight => $" {AnimateType.bounceOutRight} animated ";
        public string BounceOutUp => $" {AnimateType.bounceOutUp} animated ";

    }
    #endregion

    #region Fading Entrances
    public class SAPFadingEntrancesGroup
    {
        public string FadeIn => $" {AnimateType.fadeIn} animated ";
        public string FadeInDown => $" {AnimateType.fadeInDown} animated ";
        public string FadeInDownBig => $" {AnimateType.fadeInDownBig} animated ";
        public string FadeInLeft => $" {AnimateType.fadeInLeft} animated ";
        public string FadeInLeftBig => $" {AnimateType.fadeInLeftBig} animated ";
        public string FadeInRight => $" {AnimateType.fadeInRight} animated ";
        public string FadeInRightBig => $" {AnimateType.fadeInRightBig} animated ";
        public string FadeInUp => $" {AnimateType.fadeInUp} animated ";
        public string FadeInUpBig => $" {AnimateType.fadeInUpBig} animated ";


    }
    #endregion

    #region Fading Exits
    public class SAPFadingExitsGroup
    {
        public string FadeOut => $" {AnimateType.fadeOut} animated ";
        public string FadeOutDown => $" {AnimateType.fadeOutDown} animated ";
        public string FadeOutDownBig => $" {AnimateType.fadeOutDownBig} animated ";
        public string FadeOutLeft => $" {AnimateType.fadeOutLeft} animated ";
        public string FadeOutLeftBig => $" {AnimateType.fadeOutLeftBig} animated ";
        public string FadeOutRight => $" {AnimateType.fadeOutRight} animated ";
        public string FadeOutRightBig => $" {AnimateType.fadeOutRightBig} animated ";
        public string FadeOutUp => $" {AnimateType.fadeOutUp} animated ";
        public string FadeOutUpBig => $" {AnimateType.fadeOutUpBig} animated ";


    }
    #endregion

    #region Flippers
    public class SAPFlippersGroup
    {
        public string Flip => $" {AnimateType.flip} animated ";
        public string FlipInX => $" {AnimateType.flipInX} animated ";
        public string FlipInY => $" {AnimateType.flipInY} animated ";
        public string FlipOutX => $" {AnimateType.flipOutX} animated ";
        public string FlipOutY => $" {AnimateType.flipOutY} animated ";



    }
    #endregion

    #region Light Speed
    public class SAPLightspeedGroup
    {
        public string LightSpeedIn => $" {AnimateType.lightSpeedIn} animated ";
        public string LightSpeedOut => $" {AnimateType.lightSpeedOut} animated ";




    }
    #endregion

    #region Rotating Entrances
    public class SAPRotatingEntrancesGroup
    {
        public string RotateIn => $" {AnimateType.rotateIn} animated ";
        public string RotateInDownLeft => $" {AnimateType.rotateInDownLeft} animated ";
        public string RotateInDownRight => $" {AnimateType.rotateInDownRight} animated ";
        public string RotateInUpLeft => $" {AnimateType.rotateInUpLeft} animated ";
        public string RotateInUpRight => $" {AnimateType.rotateInUpRight} animated ";



    }
    #endregion

    #region Rotating Exits
    public class SAPRotatingExitsGroup
    {
        public string RotateOut => $" {AnimateType.rotateOut} animated ";
        public string RotateOutDownLeft => $" {AnimateType.rotateOutDownLeft} animated ";
        public string RotateOutDownRight => $" {AnimateType.rotateOutDownRight} animated ";
        public string RotateOutUpLeft => $" {AnimateType.rotateOutUpLeft} animated ";
        public string RotateOutUpRight => $" {AnimateType.rotateOutUpRight} animated ";



    }
    #endregion

    #region Sliding Entrances
    public class SAPSlidingEntrancesGroup
    {
        public string SlideInUp => $" {AnimateType.slideInUp} animated ";
        public string SlideInDown => $" {AnimateType.slideInDown} animated ";
        public string SlideInLeft => $" {AnimateType.slideInLeft} animated ";
        public string SlideInRight => $" {AnimateType.slideInRight} animated ";



    }
    #endregion

    #region Sliding Exits
    public class SAPSlidingExitsGroup
    {
        public string SlideOutUp => $" {AnimateType.slideOutUp} animated ";
        public string SlideOutDown => $" {AnimateType.slideOutDown} animated ";
        public string SlideOutLeft => $" {AnimateType.slideOutLeft} animated ";
        public string SlideOutRight => $" {AnimateType.slideOutRight} animated ";



    }
    #endregion

    #region Zoom Entrances
    public class SAPZoomEntrancesGroup
    {
        public string ZoomIn => $" {AnimateType.zoomIn} animated ";
        public string ZoomInDown => $" {AnimateType.zoomInDown} animated ";
        public string ZoomInLeft => $" {AnimateType.zoomInLeft} animated ";
        public string ZoomInRight => $" {AnimateType.zoomInRight} animated ";
        public string ZoomInUp => $" {AnimateType.zoomInUp} animated ";



    }
    #endregion

    #region Zoom Exits
    public class SAPZoomExitsGroup
    {
        public string ZoomOut => $" {AnimateType.zoomOut} animated ";
        public string ZoomOutDown => $" {AnimateType.zoomOutDown} animated ";
        public string ZoomOutLeft => $" {AnimateType.zoomOutLeft} animated ";
        public string ZoomOutRight => $" {AnimateType.zoomOutRight} animated ";
        public string ZoomOutUp => $" {AnimateType.zoomOutUp} animated ";



    }
    #endregion

    #region Specials
    public class SAPSpecialsGroup
    {
        public string Hinge => $" {AnimateType.hinge} animated ";
        public string JackInTheBox => $" {AnimateType.jackInTheBox} animated ";
        public string RollIn => $" {AnimateType.rollIn} animated ";
        public string RollOut => $" {AnimateType.rollOut} animated ";



    }
    #endregion

}
