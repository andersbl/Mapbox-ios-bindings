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
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using Security;
using SceneKit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace MapBoxIOS {
	[Register("MGLMapCamera", true)]
	public unsafe partial class MGLMapCamera : NSObject, INSCoding, INSCopying, INSSecureCoding {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MGLMapCamera");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MGLMapCamera () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public MGLMapCamera (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MGLMapCamera (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLMapCamera (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("camera")]
		[CompilerGenerated]
		public static MGLMapCamera Camera ()
		{
			return  Runtime.GetNSObject<MGLMapCamera> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("camera")));
		}
		
		[Export ("cameraLookingAtCenterCoordinate:fromEyeCoordinate:eyeAltitude:")]
		[CompilerGenerated]
		public static MGLMapCamera CameraLookingAtCenterCoordinate (global::CoreLocation.CLLocationCoordinate2D centerCoordinate, global::CoreLocation.CLLocationCoordinate2D eyeCoordinate, global::System.Double eyeAltitude)
		{
			return  Runtime.GetNSObject<MGLMapCamera> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CLLocationCoordinate2D_CLLocationCoordinate2D_Double (class_ptr, Selector.GetHandle ("cameraLookingAtCenterCoordinate:fromEyeCoordinate:eyeAltitude:"), centerCoordinate, eyeCoordinate, eyeAltitude));
		}
		
		[Export ("cameraLookingAtCenterCoordinate:fromDistance:pitch:heading:")]
		[CompilerGenerated]
		public static MGLMapCamera CameraLookingAtCenterCoordinate (global::CoreLocation.CLLocationCoordinate2D centerCoordinate, global::System.Double distance, global::System.nfloat pitch, global::System.Double heading)
		{
			return  Runtime.GetNSObject<MGLMapCamera> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CLLocationCoordinate2D_Double_nfloat_Double (class_ptr, Selector.GetHandle ("cameraLookingAtCenterCoordinate:fromDistance:pitch:heading:"), centerCoordinate, distance, pitch, heading));
		}
		
		[Export ("copyWithZone:")]
		[CompilerGenerated]
		public virtual NSObject Copy (NSZone zone)
		{
			if (zone == null)
				throw new ArgumentNullException ("zone");
			if (IsDirectBinding) {
				return Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("copyWithZone:"), zone.Handle));
			} else {
				return Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("copyWithZone:"), zone.Handle));
			}
		}
		
		[Export ("encodeWithCoder:")]
		[CompilerGenerated]
		public virtual void EncodeTo (NSCoder encoder)
		{
			if (encoder == null)
				throw new ArgumentNullException ("encoder");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("encodeWithCoder:"), encoder.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("encodeWithCoder:"), encoder.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Double Altitude {
			[Export ("altitude")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("altitude"));
				} else {
					return global::ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("altitude"));
				}
			}
			
			[Export ("setAltitude:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setAltitude:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setAltitude:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::CoreLocation.CLLocationCoordinate2D CenterCoordinate {
			[Export ("centerCoordinate", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::CoreLocation.CLLocationCoordinate2D ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CLLocationCoordinate2D_objc_msgSend (this.Handle, Selector.GetHandle ("centerCoordinate"));
						} else {
							global::ApiDefinition.Messaging.CLLocationCoordinate2D_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("centerCoordinate"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CLLocationCoordinate2D_objc_msgSend (this.Handle, Selector.GetHandle ("centerCoordinate"));
					} else {
						global::ApiDefinition.Messaging.CLLocationCoordinate2D_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("centerCoordinate"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CLLocationCoordinate2D_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("centerCoordinate"));
						} else {
							global::ApiDefinition.Messaging.CLLocationCoordinate2D_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("centerCoordinate"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CLLocationCoordinate2D_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("centerCoordinate"));
					} else {
						global::ApiDefinition.Messaging.CLLocationCoordinate2D_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("centerCoordinate"));
					}
				}
				return ret;
			}
			
			[Export ("setCenterCoordinate:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_CLLocationCoordinate2D (this.Handle, Selector.GetHandle ("setCenterCoordinate:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_CLLocationCoordinate2D (this.SuperHandle, Selector.GetHandle ("setCenterCoordinate:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Double Heading {
			[Export ("heading")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("heading"));
				} else {
					return global::ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("heading"));
				}
			}
			
			[Export ("setHeading:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setHeading:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setHeading:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat Pitch {
			[Export ("pitch")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("pitch"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pitch"));
				}
			}
			
			[Export ("setPitch:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setPitch:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setPitch:"), value);
				}
			}
		}
		
	} /* class MGLMapCamera */
}
