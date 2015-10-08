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
	[Register("MGLMapView", true)]
	public unsafe partial class MGLMapView : global::UIKit.UIView {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MGLMapView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MGLMapView () : base (NSObjectFlag.Empty)
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
		public MGLMapView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MGLMapView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLMapView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithFrame:")]
		[CompilerGenerated]
		public MGLMapView (CGRect frame)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_CGRect (this.SuperHandle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			}
		}
		
		[Export ("initWithFrame:styleURL:")]
		[CompilerGenerated]
		public MGLMapView (CGRect frame, NSUrl styleURL)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CGRect_IntPtr (this.Handle, Selector.GetHandle ("initWithFrame:styleURL:"), frame, styleURL == null ? IntPtr.Zero : styleURL.Handle), "initWithFrame:styleURL:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_CGRect_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithFrame:styleURL:"), frame, styleURL == null ? IntPtr.Zero : styleURL.Handle), "initWithFrame:styleURL:");
			}
		}
		
		[Export ("addAnnotation:")]
		[CompilerGenerated]
		public virtual void AddAnnotation (MGLAnnotation annotation)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addAnnotation:"), annotation.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addAnnotation:"), annotation.Handle);
			}
		}
		
		[Export ("addAnnotations:")]
		[CompilerGenerated]
		public virtual void AddAnnotations (MGLAnnotation[] annotations)
		{
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addAnnotations:"), nsa_annotations.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addAnnotations:"), nsa_annotations.Handle);
			}
			nsa_annotations.Dispose ();
			
		}
		
		[Export ("addStyleClass:")]
		[CompilerGenerated]
		public virtual void AddStyleClass (string styleClass)
		{
			if (styleClass == null)
				throw new ArgumentNullException ("styleClass");
			var nsstyleClass = NSString.CreateNative (styleClass);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addStyleClass:"), nsstyleClass);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addStyleClass:"), nsstyleClass);
			}
			NSString.ReleaseNative (nsstyleClass);
			
		}
		
		[Export ("convertCoordinate:toPointToView:")]
		[CompilerGenerated]
		public virtual CGPoint ConvertCoordinate (global::CoreLocation.CLLocationCoordinate2D coordinate, global::UIKit.UIView view)
		{
			CGPoint ret;
			if (IsDirectBinding) {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend_CLLocationCoordinate2D_IntPtr (this.Handle, Selector.GetHandle ("convertCoordinate:toPointToView:"), coordinate, view == null ? IntPtr.Zero : view.Handle);
					} else {
						global::ApiDefinition.Messaging.CGPoint_objc_msgSend_stret_CLLocationCoordinate2D_IntPtr (out ret, this.Handle, Selector.GetHandle ("convertCoordinate:toPointToView:"), coordinate, view == null ? IntPtr.Zero : view.Handle);
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend_CLLocationCoordinate2D_IntPtr (this.Handle, Selector.GetHandle ("convertCoordinate:toPointToView:"), coordinate, view == null ? IntPtr.Zero : view.Handle);
				} else {
					ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSend_CLLocationCoordinate2D_IntPtr (this.Handle, Selector.GetHandle ("convertCoordinate:toPointToView:"), coordinate, view == null ? IntPtr.Zero : view.Handle);
				}
			} else {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper_CLLocationCoordinate2D_IntPtr (this.SuperHandle, Selector.GetHandle ("convertCoordinate:toPointToView:"), coordinate, view == null ? IntPtr.Zero : view.Handle);
					} else {
						global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper_stret_CLLocationCoordinate2D_IntPtr (out ret, this.SuperHandle, Selector.GetHandle ("convertCoordinate:toPointToView:"), coordinate, view == null ? IntPtr.Zero : view.Handle);
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper_CLLocationCoordinate2D_IntPtr (this.SuperHandle, Selector.GetHandle ("convertCoordinate:toPointToView:"), coordinate, view == null ? IntPtr.Zero : view.Handle);
				} else {
					ret = global::ApiDefinition.Messaging.CGPoint_objc_msgSendSuper_CLLocationCoordinate2D_IntPtr (this.SuperHandle, Selector.GetHandle ("convertCoordinate:toPointToView:"), coordinate, view == null ? IntPtr.Zero : view.Handle);
				}
			}
			return ret;
		}
		
		[Export ("convertPoint:toCoordinateFromView:")]
		[CompilerGenerated]
		public virtual global::CoreLocation.CLLocationCoordinate2D ConvertPoint (CGPoint point, global::UIKit.UIView view)
		{
			global::CoreLocation.CLLocationCoordinate2D ret;
			if (IsDirectBinding) {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CLLocationCoordinate2D_objc_msgSend_CGPoint_IntPtr (this.Handle, Selector.GetHandle ("convertPoint:toCoordinateFromView:"), point, view == null ? IntPtr.Zero : view.Handle);
					} else {
						global::ApiDefinition.Messaging.CLLocationCoordinate2D_objc_msgSend_stret_CGPoint_IntPtr (out ret, this.Handle, Selector.GetHandle ("convertPoint:toCoordinateFromView:"), point, view == null ? IntPtr.Zero : view.Handle);
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.CLLocationCoordinate2D_objc_msgSend_CGPoint_IntPtr (this.Handle, Selector.GetHandle ("convertPoint:toCoordinateFromView:"), point, view == null ? IntPtr.Zero : view.Handle);
				} else {
					global::ApiDefinition.Messaging.CLLocationCoordinate2D_objc_msgSend_stret_CGPoint_IntPtr (out ret, this.Handle, Selector.GetHandle ("convertPoint:toCoordinateFromView:"), point, view == null ? IntPtr.Zero : view.Handle);
				}
			} else {
				if (Runtime.Arch == Arch.DEVICE) {
					if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CLLocationCoordinate2D_objc_msgSendSuper_CGPoint_IntPtr (this.SuperHandle, Selector.GetHandle ("convertPoint:toCoordinateFromView:"), point, view == null ? IntPtr.Zero : view.Handle);
					} else {
						global::ApiDefinition.Messaging.CLLocationCoordinate2D_objc_msgSendSuper_stret_CGPoint_IntPtr (out ret, this.SuperHandle, Selector.GetHandle ("convertPoint:toCoordinateFromView:"), point, view == null ? IntPtr.Zero : view.Handle);
					}
				} else if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.CLLocationCoordinate2D_objc_msgSendSuper_CGPoint_IntPtr (this.SuperHandle, Selector.GetHandle ("convertPoint:toCoordinateFromView:"), point, view == null ? IntPtr.Zero : view.Handle);
				} else {
					global::ApiDefinition.Messaging.CLLocationCoordinate2D_objc_msgSendSuper_stret_CGPoint_IntPtr (out ret, this.SuperHandle, Selector.GetHandle ("convertPoint:toCoordinateFromView:"), point, view == null ? IntPtr.Zero : view.Handle);
				}
			}
			return ret;
		}
		
		[Export ("dequeueReusableAnnotationImageWithIdentifier:")]
		[CompilerGenerated]
		public virtual MGLAnnotationImage DequeueReusableAnnotationImageWithIdentifier (string identifier)
		{
			if (identifier == null)
				throw new ArgumentNullException ("identifier");
			var nsidentifier = NSString.CreateNative (identifier);
			
			MGLAnnotationImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MGLAnnotationImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("dequeueReusableAnnotationImageWithIdentifier:"), nsidentifier));
			} else {
				ret =  Runtime.GetNSObject<MGLAnnotationImage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("dequeueReusableAnnotationImageWithIdentifier:"), nsidentifier));
			}
			NSString.ReleaseNative (nsidentifier);
			
			return ret;
		}
		
		[Export ("deselectAnnotation:animated:")]
		[CompilerGenerated]
		public virtual void DeselectAnnotation (MGLAnnotation annotation, bool animated)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("deselectAnnotation:animated:"), annotation.Handle, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("deselectAnnotation:animated:"), annotation.Handle, animated);
			}
		}
		
		[Export ("emptyMemoryCache")]
		[CompilerGenerated]
		public virtual void EmptyMemoryCache ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("emptyMemoryCache"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("emptyMemoryCache"));
			}
		}
		
		[Export ("hasStyleClass:")]
		[CompilerGenerated]
		public virtual bool HasStyleClass (string styleClass)
		{
			if (styleClass == null)
				throw new ArgumentNullException ("styleClass");
			var nsstyleClass = NSString.CreateNative (styleClass);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("hasStyleClass:"), nsstyleClass);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("hasStyleClass:"), nsstyleClass);
			}
			NSString.ReleaseNative (nsstyleClass);
			
			return ret;
		}
		
		[Export ("metersPerPixelAtLatitude:")]
		[CompilerGenerated]
		public virtual global::System.Double MetersPerPixelAtLatitude (global::System.Double latitude)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.Double_objc_msgSend_Double (this.Handle, Selector.GetHandle ("metersPerPixelAtLatitude:"), latitude);
			} else {
				return global::ApiDefinition.Messaging.Double_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("metersPerPixelAtLatitude:"), latitude);
			}
		}
		
		[Export ("removeAnnotation:")]
		[CompilerGenerated]
		public virtual void RemoveAnnotation (MGLAnnotation annotation)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeAnnotation:"), annotation.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeAnnotation:"), annotation.Handle);
			}
		}
		
		[Export ("removeAnnotations:")]
		[CompilerGenerated]
		public virtual void RemoveAnnotations (MGLAnnotation[] annotations)
		{
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeAnnotations:"), nsa_annotations.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeAnnotations:"), nsa_annotations.Handle);
			}
			nsa_annotations.Dispose ();
			
		}
		
		[Export ("removeStyleClass:")]
		[CompilerGenerated]
		public virtual void RemoveStyleClass (string styleClass)
		{
			if (styleClass == null)
				throw new ArgumentNullException ("styleClass");
			var nsstyleClass = NSString.CreateNative (styleClass);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeStyleClass:"), nsstyleClass);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeStyleClass:"), nsstyleClass);
			}
			NSString.ReleaseNative (nsstyleClass);
			
		}
		
		[Export ("resetNorth")]
		[CompilerGenerated]
		public virtual void ResetNorth ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("resetNorth"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("resetNorth"));
			}
		}
		
		[Export ("resetPosition")]
		[CompilerGenerated]
		public virtual void ResetPosition ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("resetPosition"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("resetPosition"));
			}
		}
		
		[Export ("selectAnnotation:animated:")]
		[CompilerGenerated]
		public virtual void SelectAnnotation (MGLAnnotation annotation, bool animated)
		{
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("selectAnnotation:animated:"), annotation.Handle, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("selectAnnotation:animated:"), annotation.Handle, animated);
			}
		}
		
		[Export ("setCamera:animated:")]
		[CompilerGenerated]
		public virtual void SetCamera (MGLMapCamera camera, bool animated)
		{
			if (camera == null)
				throw new ArgumentNullException ("camera");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("setCamera:animated:"), camera.Handle, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("setCamera:animated:"), camera.Handle, animated);
			}
		}
		
		[Export ("setCamera:withDuration:animationTimingFunction:")]
		[CompilerGenerated]
		public virtual void SetCamera (MGLMapCamera camera, global::System.Double duration, global::CoreAnimation.CAMediaTimingFunction function)
		{
			if (camera == null)
				throw new ArgumentNullException ("camera");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_Double_IntPtr (this.Handle, Selector.GetHandle ("setCamera:withDuration:animationTimingFunction:"), camera.Handle, duration, function == null ? IntPtr.Zero : function.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_Double_IntPtr (this.SuperHandle, Selector.GetHandle ("setCamera:withDuration:animationTimingFunction:"), camera.Handle, duration, function == null ? IntPtr.Zero : function.Handle);
			}
		}
		
		[Export ("setCenterCoordinate:animated:")]
		[CompilerGenerated]
		public virtual void SetCenterCoordinate (global::CoreLocation.CLLocationCoordinate2D coordinate, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_CLLocationCoordinate2D_bool (this.Handle, Selector.GetHandle ("setCenterCoordinate:animated:"), coordinate, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_CLLocationCoordinate2D_bool (this.SuperHandle, Selector.GetHandle ("setCenterCoordinate:animated:"), coordinate, animated);
			}
		}
		
		[Export ("setCenterCoordinate:zoomLevel:animated:")]
		[CompilerGenerated]
		public virtual void SetCenterCoordinate (global::CoreLocation.CLLocationCoordinate2D centerCoordinate, global::System.Double zoomLevel, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_CLLocationCoordinate2D_Double_bool (this.Handle, Selector.GetHandle ("setCenterCoordinate:zoomLevel:animated:"), centerCoordinate, zoomLevel, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_CLLocationCoordinate2D_Double_bool (this.SuperHandle, Selector.GetHandle ("setCenterCoordinate:zoomLevel:animated:"), centerCoordinate, zoomLevel, animated);
			}
		}
		
		[Export ("setCenterCoordinate:zoomLevel:direction:animated:")]
		[CompilerGenerated]
		public virtual void SetCenterCoordinate (global::CoreLocation.CLLocationCoordinate2D centerCoordinate, global::System.Double zoomLevel, global::System.Double direction, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_CLLocationCoordinate2D_Double_Double_bool (this.Handle, Selector.GetHandle ("setCenterCoordinate:zoomLevel:direction:animated:"), centerCoordinate, zoomLevel, direction, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_CLLocationCoordinate2D_Double_Double_bool (this.SuperHandle, Selector.GetHandle ("setCenterCoordinate:zoomLevel:direction:animated:"), centerCoordinate, zoomLevel, direction, animated);
			}
		}
		
		[Export ("setDirection:animated:")]
		[CompilerGenerated]
		public virtual void SetDirection (global::System.Double direction, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_Double_bool (this.Handle, Selector.GetHandle ("setDirection:animated:"), direction, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_Double_bool (this.SuperHandle, Selector.GetHandle ("setDirection:animated:"), direction, animated);
			}
		}
		
		[Export ("setZoomLevel:animated:")]
		[CompilerGenerated]
		public virtual void SetZoomLevel (global::System.Double zoomLevel, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_Double_bool (this.Handle, Selector.GetHandle ("setZoomLevel:animated:"), zoomLevel, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_Double_bool (this.SuperHandle, Selector.GetHandle ("setZoomLevel:animated:"), zoomLevel, animated);
			}
		}
		
		[Export ("showAnnotations:animated:")]
		[CompilerGenerated]
		public virtual void ShowAnnotations (MGLAnnotation[] annotations, bool animated)
		{
			if (annotations == null)
				throw new ArgumentNullException ("annotations");
			var nsa_annotations = NSArray.FromNSObjects (annotations);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("showAnnotations:animated:"), nsa_annotations.Handle, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("showAnnotations:animated:"), nsa_annotations.Handle, animated);
			}
			nsa_annotations.Dispose ();
			
		}
		
		[Export ("toggleDebug")]
		[CompilerGenerated]
		public virtual void ToggleDebug ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("toggleDebug"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("toggleDebug"));
			}
		}
		
		[CompilerGenerated]
		object __mt_Annotations_var;
		[CompilerGenerated]
		public virtual MGLAnnotation[] Annotations {
			[Export ("annotations")]
			get {
				MGLAnnotation[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MGLAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("annotations")));
				} else {
					ret = NSArray.ArrayFromHandle<MGLAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("annotations")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Annotations_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_AttributionButton_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIButton AttributionButton {
			[Export ("attributionButton")]
			get {
				global::UIKit.UIButton ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("attributionButton")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("attributionButton")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_AttributionButton_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_BundledStyleURLs_var;
		[CompilerGenerated]
		public virtual NSUrl[] BundledStyleURLs {
			[Export ("bundledStyleURLs")]
			get {
				NSUrl[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSUrl>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("bundledStyleURLs")));
				} else {
					ret = NSArray.ArrayFromHandle<NSUrl>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bundledStyleURLs")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_BundledStyleURLs_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Camera_var;
		[CompilerGenerated]
		public virtual MGLMapCamera Camera {
			[Export ("camera", ArgumentSemantic.Copy)]
			get {
				MGLMapCamera ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MGLMapCamera> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("camera")));
				} else {
					ret =  Runtime.GetNSObject<MGLMapCamera> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("camera")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Camera_var = ret;
				return ret;
			}
			
			[Export ("setCamera:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCamera:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCamera:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Camera_var = value;
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
		object __mt_CompassView_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIImageView CompassView {
			[Export ("compassView")]
			get {
				global::UIKit.UIImageView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImageView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("compassView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImageView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("compassView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_CompassView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool DebugActive {
			[Export ("isDebugActive")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isDebugActive"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isDebugActive"));
				}
			}
			
			[Export ("setDebugActive:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDebugActive:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setDebugActive:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Double Direction {
			[Export ("direction")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("direction"));
				} else {
					return global::ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("direction"));
				}
			}
			
			[Export ("setDirection:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setDirection:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setDirection:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool DisplayHeadingCalibration {
			[Export ("displayHeadingCalibration")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("displayHeadingCalibration"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("displayHeadingCalibration"));
				}
			}
			
			[Export ("setDisplayHeadingCalibration:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDisplayHeadingCalibration:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setDisplayHeadingCalibration:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_LogoView_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIImageView LogoView {
			[Export ("logoView")]
			get {
				global::UIKit.UIImageView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImageView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("logoView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImageView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("logoView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_LogoView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool PitchEnabled {
			[Export ("isPitchEnabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isPitchEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isPitchEnabled"));
				}
			}
			
			[Export ("setPitchEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setPitchEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setPitchEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool RotateEnabled {
			[Export ("isRotateEnabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isRotateEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isRotateEnabled"));
				}
			}
			
			[Export ("setRotateEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setRotateEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setRotateEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ScrollEnabled {
			[Export ("isScrollEnabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isScrollEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isScrollEnabled"));
				}
			}
			
			[Export ("setScrollEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setScrollEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setScrollEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_SelectedAnnotations_var;
		[CompilerGenerated]
		public virtual MGLAnnotation[] SelectedAnnotations {
			[Export ("selectedAnnotations", ArgumentSemantic.Copy)]
			get {
				MGLAnnotation[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MGLAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("selectedAnnotations")));
				} else {
					ret = NSArray.ArrayFromHandle<MGLAnnotation>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("selectedAnnotations")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SelectedAnnotations_var = ret;
				return ret;
			}
			
			[Export ("setSelectedAnnotations:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSelectedAnnotations:"), nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSelectedAnnotations:"), nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_SelectedAnnotations_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowsUserLocation {
			[Export ("showsUserLocation")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showsUserLocation"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showsUserLocation"));
				}
			}
			
			[Export ("setShowsUserLocation:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowsUserLocation:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShowsUserLocation:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string[] StyleClasses {
			[Export ("styleClasses", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return NSArray.StringArrayFromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("styleClasses")));
				} else {
					return NSArray.StringArrayFromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("styleClasses")));
				}
			}
			
			[Export ("setStyleClasses:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromStrings (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setStyleClasses:"), nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setStyleClasses:"), nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
			}
		}
		
		[CompilerGenerated]
		public virtual string StyleID {
			[Export ("styleID")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("styleID")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("styleID")));
				}
			}
			
			[Export ("setStyleID:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setStyleID:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setStyleID:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_StyleURL_var;
		[CompilerGenerated]
		public virtual NSUrl StyleURL {
			[Export ("styleURL", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("styleURL")));
				} else {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("styleURL")));
				}
				MarkDirty ();
				__mt_StyleURL_var = ret;
				return ret;
			}
			
			[Export ("setStyleURL:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setStyleURL:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setStyleURL:"), value.Handle);
				}
				MarkDirty ();
				__mt_StyleURL_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool UserLocationVisible {
			[Export ("isUserLocationVisible")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isUserLocationVisible"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isUserLocationVisible"));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool ZoomEnabled {
			[Export ("isZoomEnabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isZoomEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isZoomEnabled"));
				}
			}
			
			[Export ("setZoomEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setZoomEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setZoomEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Double ZoomLevel {
			[Export ("zoomLevel")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("zoomLevel"));
				} else {
					return global::ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("zoomLevel"));
				}
			}
			
			[Export ("setZoomLevel:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setZoomLevel:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setZoomLevel:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Annotations_var = null;
				__mt_AttributionButton_var = null;
				__mt_BundledStyleURLs_var = null;
				__mt_Camera_var = null;
				__mt_CompassView_var = null;
				__mt_LogoView_var = null;
				__mt_SelectedAnnotations_var = null;
				__mt_StyleURL_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
		public partial class MGLMapViewAppearance : UIView.UIViewAppearance {
			protected internal MGLMapViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new MGLMapViewAppearance Appearance {
			get { return new MGLMapViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new MGLMapViewAppearance GetAppearance<T> () where T: MGLMapView {
			return new MGLMapViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new MGLMapViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new MGLMapViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new MGLMapViewAppearance GetAppearance (UITraitCollection traits) {
			return new MGLMapViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new MGLMapViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new MGLMapViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new MGLMapViewAppearance GetAppearance<T> (UITraitCollection traits) where T: MGLMapView {
			return new MGLMapViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new MGLMapViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: MGLMapView{
			return new MGLMapViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class MGLMapView */
}
