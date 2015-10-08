using System;
using CoreAnimation;
using CoreGraphics;
using CoreLocation;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace MapBoxIOS
{


	// @interface MGLAccountManager : NSObject
	[BaseType (typeof(NSObject))]
	interface MGLAccountManager
	{
		// +(NSString * _Nullable)accessToken;
		// +(void)setAccessToken:(NSString * _Nullable)accessToken;
		[Static]
		[NullAllowed, Export ("accessToken")]

		string AccessToken { get; set; }

		// +(BOOL)mapboxMetricsEnabledSettingShownInApp;
		// +(void)setMapboxMetricsEnabledSettingShownInApp:(BOOL)showsOptOut __attribute__((unavailable("Set MGLMapboxMetricsEnabledSettingShownInApp in Info.plist.")));
		[Static]
		[Export ("mapboxMetricsEnabledSettingShownInApp")]

		bool MapboxMetricsEnabledSettingShownInApp { get; set; }
	}

	// @protocol MGLAnnotation <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MGLAnnotation
	{
		// @required @property (readonly, nonatomic) CLLocationCoordinate2D coordinate;
		[Export ("coordinate")]
		CLLocationCoordinate2D Coordinate { get; }

		// @optional @property (readonly, copy, nonatomic) NSString * _Nullable title;
		[NullAllowed, Export ("title")]
		string Title { get; }

		// @optional @property (readonly, copy, nonatomic) NSString * _Nullable subtitle;
		[NullAllowed, Export ("subtitle")]
		string Subtitle { get; }
	}

	// @interface MGLAnnotationImage : NSObject
	[BaseType (typeof(NSObject))]
	interface MGLAnnotationImage
	{
		// @property (readonly, nonatomic) UIImage * _Nonnull image;
		[Export ("image")]
		UIImage Image { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull reuseIdentifier;
		[Export ("reuseIdentifier")]
		string ReuseIdentifier { get; }

		// +(instancetype _Nonnull)annotationImageWithImage:(UIImage * _Nonnull)image reuseIdentifier:(NSString * _Nonnull)reuseIdentifier;
		[Static]
		[Export ("annotationImageWithImage:reuseIdentifier:")]
		MGLAnnotationImage AnnotationImageWithImage (UIImage image, string reuseIdentifier);
	}

	// @interface MGLMapCamera : NSObject <NSSecureCoding, NSCopying>
	[BaseType (typeof(NSObject))]
	interface MGLMapCamera : INSSecureCoding, INSCopying
	{
		// @property (nonatomic) CLLocationCoordinate2D centerCoordinate;
		[Export ("centerCoordinate", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D CenterCoordinate { get; set; }

		// @property (nonatomic) CLLocationDirection heading;
		[Export ("heading")]
		double Heading { get; set; }

		// @property (nonatomic) CGFloat pitch;
		[Export ("pitch")]
		nfloat Pitch { get; set; }

		// @property (nonatomic) CLLocationDistance altitude;
		[Export ("altitude")]
		double Altitude { get; set; }

		// +(instancetype _Nonnull)camera;
		[Static]
		[Export ("camera")]
		MGLMapCamera Camera ();

		// +(instancetype _Nonnull)cameraLookingAtCenterCoordinate:(CLLocationCoordinate2D)centerCoordinate fromEyeCoordinate:(CLLocationCoordinate2D)eyeCoordinate eyeAltitude:(CLLocationDistance)eyeAltitude;
		[Static]
		[Export ("cameraLookingAtCenterCoordinate:fromEyeCoordinate:eyeAltitude:")]
		MGLMapCamera CameraLookingAtCenterCoordinate (CLLocationCoordinate2D centerCoordinate, CLLocationCoordinate2D eyeCoordinate, double eyeAltitude);

		// +(instancetype _Nonnull)cameraLookingAtCenterCoordinate:(CLLocationCoordinate2D)centerCoordinate fromDistance:(CLLocationDistance)distance pitch:(CGFloat)pitch heading:(CLLocationDirection)heading;
		[Static]
		[Export ("cameraLookingAtCenterCoordinate:fromDistance:pitch:heading:")]
		MGLMapCamera CameraLookingAtCenterCoordinate (CLLocationCoordinate2D centerCoordinate, double distance, nfloat pitch, double heading);
	}



	// @interface MGLMapView : UIView
	[BaseType (typeof(UIView))]
	interface MGLMapView
	{
		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame;
		[Export ("initWithFrame:")]
		IntPtr Constructor (CGRect frame);

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame styleURL:(NSURL * _Nullable)styleURL;
		[Export ("initWithFrame:styleURL:")]
		IntPtr Constructor (CGRect frame, [NullAllowed] NSUrl styleURL);

		// @property (getter = isZoomEnabled, nonatomic) BOOL zoomEnabled;
		[Export ("zoomEnabled")]
		bool ZoomEnabled { [Bind ("isZoomEnabled")] get; set; }

		// @property (getter = isScrollEnabled, nonatomic) BOOL scrollEnabled;
		[Export ("scrollEnabled")]
		bool ScrollEnabled { [Bind ("isScrollEnabled")] get; set; }

		// @property (getter = isRotateEnabled, nonatomic) BOOL rotateEnabled;
		[Export ("rotateEnabled")]
		bool RotateEnabled { [Bind ("isRotateEnabled")] get; set; }

		// @property (getter = isPitchEnabled, nonatomic) BOOL pitchEnabled;
		[Export ("pitchEnabled")]
		bool PitchEnabled { [Bind ("isPitchEnabled")] get; set; }

		// @property (readonly, nonatomic) UIImageView * _Nonnull compassView;
		[Export ("compassView")]
		UIImageView CompassView { get; }

		// @property (readonly, nonatomic) UIImageView * _Nonnull logoView;
		[Export ("logoView")]
		UIImageView LogoView { get; }

		// @property (readonly, nonatomic) UIButton * _Nonnull attributionButton;
		[Export ("attributionButton")]
		UIButton AttributionButton { get; }


		// @property (nonatomic, weak) id<MGLMapViewDelegate> _Nullable delegate __attribute__((iboutlet));
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic) CLLocationCoordinate2D centerCoordinate;
		[Export ("centerCoordinate", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D CenterCoordinate { get; set; }

		// -(void)setCenterCoordinate:(CLLocationCoordinate2D)coordinate animated:(BOOL)animated;
		[Export ("setCenterCoordinate:animated:")]
		void SetCenterCoordinate (CLLocationCoordinate2D coordinate, bool animated);

		// @property (nonatomic) double zoomLevel;
		[Export ("zoomLevel")]
		double ZoomLevel { get; set; }

		// -(void)setZoomLevel:(double)zoomLevel animated:(BOOL)animated;
		[Export ("setZoomLevel:animated:")]
		void SetZoomLevel (double zoomLevel, bool animated);

		// -(void)setCenterCoordinate:(CLLocationCoordinate2D)centerCoordinate zoomLevel:(double)zoomLevel animated:(BOOL)animated;
		[Export ("setCenterCoordinate:zoomLevel:animated:")]
		void SetCenterCoordinate (CLLocationCoordinate2D centerCoordinate, double zoomLevel, bool animated);

		// -(void)setCenterCoordinate:(CLLocationCoordinate2D)centerCoordinate zoomLevel:(double)zoomLevel direction:(CLLocationDirection)direction animated:(BOOL)animated;
		[Export ("setCenterCoordinate:zoomLevel:direction:animated:")]
		void SetCenterCoordinate (CLLocationCoordinate2D centerCoordinate, double zoomLevel, double direction, bool animated);


	
		// -(void)showAnnotations:(NSArray<id<MGLAnnotation>> * _Nonnull)annotations animated:(BOOL)animated;
		[Export ("showAnnotations:animated:")]
		void ShowAnnotations (MGLAnnotation[] annotations, bool animated);

		// @property (nonatomic) CLLocationDirection direction;
		[Export ("direction")]
		double Direction { get; set; }

		// -(void)setDirection:(CLLocationDirection)direction animated:(BOOL)animated;
		[Export ("setDirection:animated:")]
		void SetDirection (double direction, bool animated);

		// -(void)resetNorth __attribute__((ibaction));
		[Export ("resetNorth")]
		void ResetNorth ();

		// @property (copy, nonatomic) MGLMapCamera * _Nonnull camera;
		[Export ("camera", ArgumentSemantic.Copy)]
		MGLMapCamera Camera { get; set; }

		// -(void)setCamera:(MGLMapCamera * _Nonnull)camera animated:(BOOL)animated;
		[Export ("setCamera:animated:")]
		void SetCamera (MGLMapCamera camera, bool animated);

		// -(void)setCamera:(MGLMapCamera * _Nonnull)camera withDuration:(NSTimeInterval)duration animationTimingFunction:(CAMediaTimingFunction * _Nullable)function;
		[Export ("setCamera:withDuration:animationTimingFunction:")]
		void SetCamera (MGLMapCamera camera, double duration, [NullAllowed] CAMediaTimingFunction function);

		// -(CLLocationCoordinate2D)convertPoint:(CGPoint)point toCoordinateFromView:(UIView * _Nullable)view;
		[Export ("convertPoint:toCoordinateFromView:")]
		CLLocationCoordinate2D ConvertPoint (CGPoint point, [NullAllowed] UIView view);

		// -(CGPoint)convertCoordinate:(CLLocationCoordinate2D)coordinate toPointToView:(UIView * _Nullable)view;
		[Export ("convertCoordinate:toPointToView:")]
		CGPoint ConvertCoordinate (CLLocationCoordinate2D coordinate, [NullAllowed] UIView view);

		// -(CLLocationDistance)metersPerPixelAtLatitude:(CLLocationDegrees)latitude;
		[Export ("metersPerPixelAtLatitude:")]
		double MetersPerPixelAtLatitude (double latitude);

		// @property (nonatomic) NSString * _Nullable styleID;
		[NullAllowed, Export ("styleID")]
		string StyleID { get; set; }

		// @property (readonly, nonatomic) NSArray<NSURL *> * _Nonnull bundledStyleURLs;
		[Export ("bundledStyleURLs")]
		NSUrl[] BundledStyleURLs { get; }

		// @property (nonatomic) NSURL * _Null_unspecified styleURL;
		[Export ("styleURL", ArgumentSemantic.Assign)]
		NSUrl StyleURL { get; set; }

		// @property (nonatomic) NSArray<NSString *> * _Nonnull styleClasses;
		[Export ("styleClasses", ArgumentSemantic.Assign)]
		string[] StyleClasses { get; set; }

		// -(BOOL)hasStyleClass:(NSString * _Nonnull)styleClass;
		[Export ("hasStyleClass:")]
		bool HasStyleClass (string styleClass);

		// -(void)addStyleClass:(NSString * _Nonnull)styleClass;
		[Export ("addStyleClass:")]
		void AddStyleClass (string styleClass);

		// -(void)removeStyleClass:(NSString * _Nonnull)styleClass;
		[Export ("removeStyleClass:")]
		void RemoveStyleClass (string styleClass);

		// @property (readonly, nonatomic) NSArray<id<MGLAnnotation>> * _Nullable annotations;
		[NullAllowed, Export ("annotations")]
		MGLAnnotation[] Annotations { get; }

		// -(void)addAnnotation:(id<MGLAnnotation> _Nonnull)annotation;
		[Export ("addAnnotation:")]
		void AddAnnotation (MGLAnnotation annotation);

		// -(void)addAnnotations:(NSArray<id<MGLAnnotation>> * _Nonnull)annotations;
		[Export ("addAnnotations:")]
		void AddAnnotations (MGLAnnotation[] annotations);

		// -(void)removeAnnotation:(id<MGLAnnotation> _Nonnull)annotation;
		[Export ("removeAnnotation:")]
		void RemoveAnnotation (MGLAnnotation annotation);

		// -(void)removeAnnotations:(NSArray<id<MGLAnnotation>> * _Nonnull)annotations;
		[Export ("removeAnnotations:")]
		void RemoveAnnotations (MGLAnnotation[] annotations);

		// -(MGLAnnotationImage * _Nullable)dequeueReusableAnnotationImageWithIdentifier:(NSString * _Nonnull)identifier;
		[Export ("dequeueReusableAnnotationImageWithIdentifier:")]
		[return: NullAllowed]
		MGLAnnotationImage DequeueReusableAnnotationImageWithIdentifier (string identifier);

		// @property (copy, nonatomic) NSArray<id<MGLAnnotation>> * _Nonnull selectedAnnotations;
		[Export ("selectedAnnotations", ArgumentSemantic.Copy)]
		MGLAnnotation[] SelectedAnnotations { get; set; }

		// -(void)selectAnnotation:(id<MGLAnnotation> _Nonnull)annotation animated:(BOOL)animated;
		[Export ("selectAnnotation:animated:")]
		void SelectAnnotation (MGLAnnotation annotation, bool animated);

		// -(void)deselectAnnotation:(id<MGLAnnotation> _Nonnull)annotation animated:(BOOL)animated;
		[Export ("deselectAnnotation:animated:")]
		void DeselectAnnotation (MGLAnnotation annotation, bool animated);


		// @property (assign, nonatomic) BOOL showsUserLocation;
		[Export ("showsUserLocation")]
		bool ShowsUserLocation { get; set; }

		// @property (readonly, getter = isUserLocationVisible, assign, nonatomic) BOOL userLocationVisible;
		[Export ("userLocationVisible")]
		bool UserLocationVisible { [Bind ("isUserLocationVisible")] get; }


		// @property (assign, nonatomic) BOOL displayHeadingCalibration;
		[Export ("displayHeadingCalibration")]
		bool DisplayHeadingCalibration { get; set; }

		// @property (getter = isDebugActive, nonatomic) BOOL debugActive;
		[Export ("debugActive")]
		bool DebugActive { [Bind ("isDebugActive")] get; set; }

		// -(void)toggleDebug;
		[Export ("toggleDebug")]
		void ToggleDebug ();

		// -(void)emptyMemoryCache;
		[Export ("emptyMemoryCache")]
		void EmptyMemoryCache ();

		// -(void)resetPosition;
		[Export ("resetPosition")]
		void ResetPosition ();
	}








}
