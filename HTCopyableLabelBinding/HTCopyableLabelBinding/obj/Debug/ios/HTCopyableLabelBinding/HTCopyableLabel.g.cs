//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using MonoTouch.UIKit;
using MonoTouch.GLKit;
using MonoTouch.MapKit;
using MonoTouch.Security;
using MonoTouch.CoreVideo;
using MonoTouch.CoreMedia;
using MonoTouch.QuickLook;
using MonoTouch.Foundation;
using MonoTouch.CoreMotion;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreGraphics;
using MonoTouch.CoreLocation;
using MonoTouch.NewsstandKit;
using MonoTouch.AVFoundation;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreFoundation;

namespace HTCopyableLabelBinding {
	[Register("HTCopyableLabel", true)]
	public unsafe partial class HTCopyableLabel : global::MonoTouch.UIKit.UILabel {
		[CompilerGenerated]
		const string selCopyableLabelDelegate = "copyableLabelDelegate";
		static readonly IntPtr selCopyableLabelDelegateHandle = Selector.GetHandle ("copyableLabelDelegate");
		[CompilerGenerated]
		const string selCopyingEnabled = "copyingEnabled";
		static readonly IntPtr selCopyingEnabledHandle = Selector.GetHandle ("copyingEnabled");
		[CompilerGenerated]
		const string selCopyMenuArrowDirection = "copyMenuArrowDirection";
		static readonly IntPtr selCopyMenuArrowDirectionHandle = Selector.GetHandle ("copyMenuArrowDirection");
		[CompilerGenerated]
		const string selLongPressGestureRecognizer = "longPressGestureRecognizer";
		static readonly IntPtr selLongPressGestureRecognizerHandle = Selector.GetHandle ("longPressGestureRecognizer");
		[CompilerGenerated]
		const string selSetCopyableLabelDelegate_ = "setCopyableLabelDelegate:";
		static readonly IntPtr selSetCopyableLabelDelegate_Handle = Selector.GetHandle ("setCopyableLabelDelegate:");
		[CompilerGenerated]
		const string selSetCopyingEnabled_ = "setCopyingEnabled:";
		static readonly IntPtr selSetCopyingEnabled_Handle = Selector.GetHandle ("setCopyingEnabled:");
		[CompilerGenerated]
		const string selSetCopyMenuArrowDirection_ = "setCopyMenuArrowDirection:";
		static readonly IntPtr selSetCopyMenuArrowDirection_Handle = Selector.GetHandle ("setCopyMenuArrowDirection:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("HTCopyableLabel");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public HTCopyableLabel () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::MonoTouch.ObjCRuntime.Selector.Init), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::MonoTouch.ObjCRuntime.Selector.Init), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public HTCopyableLabel (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public HTCopyableLabel (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public HTCopyableLabel (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		object __mt_CopyableLabelDelegate_var;
		[CompilerGenerated]
		public virtual HTCopyableLabelDelegate CopyableLabelDelegate {
			[Export ("copyableLabelDelegate", ArgumentSemantic.UnsafeUnretained)]
			get {
				HTCopyableLabelDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<HTCopyableLabelDelegate> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selCopyableLabelDelegateHandle));
				} else {
					ret =  Runtime.GetNSObject<HTCopyableLabelDelegate> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCopyableLabelDelegateHandle));
				}
				MarkDirty ();
				__mt_CopyableLabelDelegate_var = ret;
				return ret;
			}
			
			[Export ("setCopyableLabelDelegate:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetCopyableLabelDelegate_Handle, value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetCopyableLabelDelegate_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_CopyableLabelDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool CopyingEnabled {
			[Export ("copyingEnabled")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, selCopyingEnabledHandle);
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selCopyingEnabledHandle);
				}
			}
			
			[Export ("setCopyingEnabled:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, selSetCopyingEnabled_Handle, value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetCopyingEnabled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIMenuControllerArrowDirection CopyMenuArrowDirection {
			[Export ("copyMenuArrowDirection")]
			get {
				if (IsDirectBinding) {
					return (global::MonoTouch.UIKit.UIMenuControllerArrowDirection) ApiDefinition.Messaging.int_objc_msgSend (this.Handle, selCopyMenuArrowDirectionHandle);
				} else {
					return (global::MonoTouch.UIKit.UIMenuControllerArrowDirection) ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, selCopyMenuArrowDirectionHandle);
				}
			}
			
			[Export ("setCopyMenuArrowDirection:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, selSetCopyMenuArrowDirection_Handle, (int)value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetCopyMenuArrowDirection_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_LongPressGestureRecognizer_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UILongPressGestureRecognizer LongPressGestureRecognizer {
			[Export ("longPressGestureRecognizer", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UILongPressGestureRecognizer ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UILongPressGestureRecognizer> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selLongPressGestureRecognizerHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UILongPressGestureRecognizer> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLongPressGestureRecognizerHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_LongPressGestureRecognizer_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_CopyableLabelDelegate_var = null;
				__mt_LongPressGestureRecognizer_var = null;
			}
		}
	} /* class HTCopyableLabel */
}
