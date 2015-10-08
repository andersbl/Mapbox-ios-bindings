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
	[Protocol (Name = "MGLAnnotation", WrapperType = typeof (MGLAnnotationWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Coordinate", Selector = "coordinate", PropertyType = typeof (CLLocationCoordinate2D), GetterSelector = "coordinate", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Title", Selector = "title", PropertyType = typeof (string), GetterSelector = "title", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Subtitle", Selector = "subtitle", PropertyType = typeof (string), GetterSelector = "subtitle", ArgumentSemantic = ArgumentSemantic.None)]
	public interface IMGLAnnotation : INativeObject, IDisposable
	{
	}
	
	public static partial class MGLAnnotation_Extensions {
		[CompilerGenerated]
		public static global::CoreLocation.CLLocationCoordinate2D GetCoordinate (this IMGLAnnotation This)
		{
			global::CoreLocation.CLLocationCoordinate2D ret;
			if (Runtime.Arch == Arch.DEVICE) {
				if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.CLLocationCoordinate2D_objc_msgSend (This.Handle, Selector.GetHandle ("coordinate"));
				} else {
					global::ApiDefinition.Messaging.CLLocationCoordinate2D_objc_msgSend_stret (out ret, This.Handle, Selector.GetHandle ("coordinate"));
				}
			} else if (IntPtr.Size == 8) {
				ret = global::ApiDefinition.Messaging.CLLocationCoordinate2D_objc_msgSend (This.Handle, Selector.GetHandle ("coordinate"));
			} else {
				global::ApiDefinition.Messaging.CLLocationCoordinate2D_objc_msgSend_stret (out ret, This.Handle, Selector.GetHandle ("coordinate"));
			}
			return ret;
		}
		
		[CompilerGenerated]
		public static string GetTitle (this IMGLAnnotation This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("title")));
		}
		
		[CompilerGenerated]
		public static string GetSubtitle (this IMGLAnnotation This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("subtitle")));
		}
		
	}
	
	internal sealed class MGLAnnotationWrapper : BaseWrapper, IMGLAnnotation {
		public MGLAnnotationWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public MGLAnnotationWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace MapBoxIOS {
	[Protocol]
	[Register("MGLAnnotation", false)]
	[Model]
	public unsafe partial class MGLAnnotation : NSObject, IMGLAnnotation {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MGLAnnotation () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MGLAnnotation (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MGLAnnotation (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual global::CoreLocation.CLLocationCoordinate2D Coordinate {
			[Export ("coordinate")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Subtitle {
			[Export ("subtitle")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Title {
			[Export ("title")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
	} /* class MGLAnnotation */
}
