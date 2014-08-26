using System.Drawing;
using System;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace HTCopyableLabelBinding {

	[Model, BaseType (typeof (NSObject))]
	public partial interface HTCopyableLabelDelegate {

		[Export ("stringToCopyForCopyableLabel:")]
		string StringToCopy(HTCopyableLabel copyableLabel);

		[Export ("copyMenuTargetRectInCopyableLabelCoordinates:")]
		RectangleF CopyMenuTargetRect(HTCopyableLabel copyableLabel);
	}

	[BaseType (typeof (UILabel))]
	public partial interface HTCopyableLabel {

		[Export ("copyingEnabled")]
		bool CopyingEnabled { get; set; }

		[Export ("copyableLabelDelegate", ArgumentSemantic.Assign)]
		HTCopyableLabelDelegate CopyableLabelDelegate { get; set; }

		[Export ("copyMenuArrowDirection")]
		UIMenuControllerArrowDirection CopyMenuArrowDirection { get; set; }

		[Export ("longPressGestureRecognizer", ArgumentSemantic.Retain)]
		UILongPressGestureRecognizer LongPressGestureRecognizer { get; }
	}
}
