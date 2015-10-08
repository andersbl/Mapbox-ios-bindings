namespace MapBoxIOS {

	// @interface MGLAccountManager : NSObject
	[BaseType (typeof (NSObject))]
	interface MGLAccountManager {

		// +(void)setAccessToken:(NSString *)accessToken;
		[Static, Export ("setAccessToken:")]
		void SetAccessToken (string accessToken);

		// +(NSString *)accessToken;
		[Static, Export ("accessToken")]
		string AccessToken ();

		// +(void)setMapboxMetricsEnabledSettingShownInApp:(BOOL)showsOptOut;
		[Availability (Unavailable = Platform.iOS | Platform.Mac)]
		[Static, Export ("setMapboxMetricsEnabledSettingShownInApp:")]
		void SetMapboxMetricsEnabledSettingShownInApp (bool showsOptOut);

		// +(BOOL)mapboxMetricsEnabledSettingShownInApp;
		[Static, Export ("mapboxMetricsEnabledSettingShownInApp")]
		bool MapboxMetricsEnabledSettingShownInApp ();
	}

	// @protocol MGLAnnotation <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface MGLAnnotation {

		// @property (readonly, nonatomic) CLLocationCoordinate2D coordinate;
		[Export ("coordinate")]
		 Coordinate { get; }

		// @optional @property (readonly, copy, nonatomic) NSString * title;
		[Export ("title")]
		string Title { get; }

		// @optional @property (readonly, copy, nonatomic) NSString * subtitle;
		[Export ("subtitle")]
		string Subtitle { get; }
	}

	// @interface MGLAnnotationImage : NSObject
	[BaseType (typeof (NSObject))]
	interface MGLAnnotationImage {

		// @property (readonly, nonatomic) UIImage * image;
		[Export ("image")]
		UIImage Image { get; }

		// @property (readonly, nonatomic) NSString * reuseIdentifier;
		[Export ("reuseIdentifier")]
		string ReuseIdentifier { get; }

		// +(instancetype)annotationImageWithImage:(UIImage *)image reuseIdentifier:(NSString *)reuseIdentifier;
		[Static, Export ("annotationImageWithImage:reuseIdentifier:")]
		MGLAnnotationImage AnnotationImageWithImage (UIImage image, string reuseIdentifier);
	}

	// @interface MGLMapCamera : NSObject <NSSecureCoding, NSCopying>
	[BaseType (typeof (NSObject))]
	interface MGLMapCamera : NSSecureCoding, NSCopying {

		// @property (nonatomic) CLLocationCoordinate2D centerCoordinate;
		[Export ("centerCoordinate")]
		 CenterCoordinate { get; set; }

		// @property (nonatomic) CLLocationDirection heading;
		[Export ("heading")]
		double Heading { get; set; }

		// @property (nonatomic) CGFloat pitch;
		[Export ("pitch")]
		nfloat Pitch { get; set; }

		// @property (nonatomic) CLLocationDistance altitude;
		[Export ("altitude")]
		double Altitude { get; set; }

		// +(instancetype)camera;
		[Static, Export ("camera")]
		MGLMapCamera Camera ();

		// +(instancetype)cameraLookingAtCenterCoordinate:(CLLocationCoordinate2D)centerCoordinate fromEyeCoordinate:(CLLocationCoordinate2D)eyeCoordinate eyeAltitude:(CLLocationDistance)eyeAltitude;
		[Static, Export ("cameraLookingAtCenterCoordinate:fromEyeCoordinate:eyeAltitude:")]
		MGLMapCamera CameraLookingAtCenterCoordinate ( centerCoordinate,  eyeCoordinate, double eyeAltitude);

		// +(instancetype)cameraLookingAtCenterCoordinate:(CLLocationCoordinate2D)centerCoordinate fromDistance:(CLLocationDistance)distance pitch:(CGFloat)pitch heading:(CLLocationDirection)heading;
		[Static, Export ("cameraLookingAtCenterCoordinate:fromDistance:pitch:heading:")]
		MGLMapCamera CameraLookingAtCenterCoordinate ( centerCoordinate, double distance, nfloat pitch, double heading);
	}

	// @protocol MGLMapViewDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface MGLMapViewDelegate {

	}

	// @protocol MGLAnnotation <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface MGLAnnotation {

	}

	// @protocol MGLOverlay <MGLAnnotation>
	[Protocol, Model]
	interface MGLOverlay : MGLAnnotation {

	}

	// @interface MGLMapView : UIView
	[BaseType (typeof (UIView))]
	interface MGLMapView {

		// -(instancetype)initWithFrame:(CGRect)frame;
		[Export ("initWithFrame:")]
		IntPtr Constructor (CGRect frame);

		// -(instancetype)initWithFrame:(CGRect)frame accessToken:(NSString *)accessToken;
		[Availability (Unavailable = Platform.iOS | Platform.Mac)]
		[Export ("initWithFrame:accessToken:")]
		IntPtr Constructor (CGRect frame, string accessToken);

		// -(instancetype)initWithFrame:(CGRect)frame styleURL:(NSURL *)styleURL;
		[Export ("initWithFrame:styleURL:")]
		IntPtr Constructor (CGRect frame, NSUrl styleURL);

		// -(instancetype)initWithFrame:(CGRect)frame accessToken:(NSString *)accessToken styleURL:(NSURL *)styleURL;
		[Availability (Unavailable = Platform.iOS | Platform.Mac)]
		[Export ("initWithFrame:accessToken:styleURL:")]
		IntPtr Constructor (CGRect frame, string accessToken, NSUrl styleURL);

		// @property (nonatomic) NSString * accessToken;
		[Availability (Unavailable = Platform.iOS | Platform.Mac)]
		[Export ("accessToken")]
		string AccessToken { get; set; }

		// @property (nonatomic, getter = isZoomEnabled) BOOL zoomEnabled;
		[Export ("zoomEnabled")]
		bool ZoomEnabled { [Bind ("isZoomEnabled")] get; set; }

		// @property (nonatomic, getter = isScrollEnabled) BOOL scrollEnabled;
		[Export ("scrollEnabled")]
		bool ScrollEnabled { [Bind ("isScrollEnabled")] get; set; }

		// @property (nonatomic, getter = isRotateEnabled) BOOL rotateEnabled;
		[Export ("rotateEnabled")]
		bool RotateEnabled { [Bind ("isRotateEnabled")] get; set; }

		// @property (nonatomic, getter = isPitchEnabled) BOOL pitchEnabled;
		[Export ("pitchEnabled")]
		bool PitchEnabled { [Bind ("isPitchEnabled")] get; set; }

		// @property (readonly, nonatomic) UIImageView * compassView;
		[Export ("compassView")]
		UIImageView CompassView { get; }

		// @property (readonly, nonatomic) UIImageView * logoView;
		[Export ("logoView")]
		UIImageView LogoView { get; }

		// @property (readonly, nonatomic) UIButton * attributionButton;
		[Export ("attributionButton")]
		UIButton AttributionButton { get; }

		// @property (nonatomic, weak) id<MGLMapViewDelegate> delegate;
		[Export ("delegate", ArgumentSemantic.Weak)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, weak) id<MGLMapViewDelegate> delegate;
		[Wrap ("WeakDelegate")]
		MGLMapViewDelegate Delegate { get; set; }

		// @property (nonatomic) CLLocationCoordinate2D centerCoordinate;
		[Export ("centerCoordinate")]
		 CenterCoordinate { get; set; }

		// @property (nonatomic) double zoomLevel;
		[Export ("zoomLevel")]
		double ZoomLevel { get; set; }

		// @property (nonatomic) MGLCoordinateBounds visibleCoordinateBounds;
		[Export ("visibleCoordinateBounds")]
		 VisibleCoordinateBounds { get; set; }

		// @property (nonatomic) CLLocationDirection direction;
		[Export ("direction")]
		double Direction { get; set; }

		// @property (copy, nonatomic) MGLMapCamera * camera;
		[Export ("camera", ArgumentSemantic.Copy)]
		MGLMapCamera Camera { get; set; }

		// @property (nonatomic) NSString * styleID;
		[Export ("styleID")]
		string StyleID { get; set; }

		// @property (nonatomic) NSString * mapID;
		[Availability (Unavailable = Platform.iOS | Platform.Mac)]
		[Export ("mapID")]
		string MapID { get; set; }

		// @property (readonly, nonatomic) NSArray * bundledStyleURLs;
		[Export ("bundledStyleURLs")]
		NSObject [] BundledStyleURLs { get; }

		// @property (nonatomic) NSURL * styleURL;
		[Export ("styleURL")]
		NSUrl StyleURL { get; set; }

		// @property (nonatomic) NSArray * styleClasses;
		[Export ("styleClasses")]
		NSObject [] StyleClasses { get; set; }

		// @property (readonly, nonatomic) NSArray * annotations;
		[Export ("annotations")]
		NSObject [] Annotations { get; }

		// @property (copy, nonatomic) NSArray * selectedAnnotations;
		[Export ("selectedAnnotations", ArgumentSemantic.Copy)]
		NSObject [] SelectedAnnotations { get; set; }

		// @property (assign, nonatomic) BOOL showsUserLocation;
		[Export ("showsUserLocation", ArgumentSemantic.UnsafeUnretained)]
		bool ShowsUserLocation { get; set; }

		// @property (readonly, assign, nonatomic, getter = isUserLocationVisible) BOOL userLocationVisible;
		[Export ("userLocationVisible", ArgumentSemantic.UnsafeUnretained)]
		bool UserLocationVisible { [Bind ("isUserLocationVisible")] get; }

		// @property (readonly, nonatomic) MGLUserLocation * userLocation;
		[Export ("userLocation")]
		MGLUserLocation UserLocation { get; }

		// @property (assign, nonatomic) MGLUserTrackingMode userTrackingMode;
		[Export ("userTrackingMode", ArgumentSemantic.UnsafeUnretained)]
		MGLUserTrackingMode UserTrackingMode { get; set; }

		// @property (assign, nonatomic) BOOL displayHeadingCalibration;
		[Export ("displayHeadingCalibration", ArgumentSemantic.UnsafeUnretained)]
		bool DisplayHeadingCalibration { get; set; }

		// @property (nonatomic, getter = isDebugActive) BOOL debugActive;
		[Export ("debugActive")]
		bool DebugActive { [Bind ("isDebugActive")] get; set; }

		// -(void)setCenterCoordinate:(CLLocationCoordinate2D)coordinate animated:(BOOL)animated;
		[Export ("setCenterCoordinate:animated:")]
		void SetCenterCoordinate ( coordinate, bool animated);

		// -(void)setZoomLevel:(double)zoomLevel animated:(BOOL)animated;
		[Export ("setZoomLevel:animated:")]
		void SetZoomLevel (double zoomLevel, bool animated);

		// -(void)setCenterCoordinate:(CLLocationCoordinate2D)centerCoordinate zoomLevel:(double)zoomLevel animated:(BOOL)animated;
		[Export ("setCenterCoordinate:zoomLevel:animated:")]
		void SetCenterCoordinate ( centerCoordinate, double zoomLevel, bool animated);

		// -(void)setCenterCoordinate:(CLLocationCoordinate2D)centerCoordinate zoomLevel:(double)zoomLevel direction:(CLLocationDirection)direction animated:(BOOL)animated;
		[Export ("setCenterCoordinate:zoomLevel:direction:animated:")]
		void SetCenterCoordinate ( centerCoordinate, double zoomLevel, double direction, bool animated);

		// -(void)setVisibleCoordinateBounds:(MGLCoordinateBounds)bounds animated:(BOOL)animated;
		[Export ("setVisibleCoordinateBounds:animated:")]
		void SetVisibleCoordinateBounds ( bounds, bool animated);

		// -(void)setVisibleCoordinateBounds:(MGLCoordinateBounds)bounds edgePadding:(UIEdgeInsets)insets animated:(BOOL)animated;
		[Export ("setVisibleCoordinateBounds:edgePadding:animated:")]
		void SetVisibleCoordinateBounds ( bounds, UIEdgeInsets insets, bool animated);

		// -(void)setVisibleCoordinates:(CLLocationCoordinate2D *)coordinates count:(NSUInteger)count edgePadding:(UIEdgeInsets)insets animated:(BOOL)animated;
		[Export ("setVisibleCoordinates:count:edgePadding:animated:")]
		void SetVisibleCoordinates ( coordinates, nuint count, UIEdgeInsets insets, bool animated);

		// -(void)showAnnotations:(NSArray *)annotations animated:(BOOL)animated;
		[Export ("showAnnotations:animated:")]
		void ShowAnnotations (NSObject [] annotations, bool animated);

		// -(void)setDirection:(CLLocationDirection)direction animated:(BOOL)animated;
		[Export ("setDirection:animated:")]
		void SetDirection (double direction, bool animated);

		// -(void)resetNorth;
		[Export ("resetNorth")]
		void ResetNorth ();

		// -(void)setCamera:(MGLMapCamera *)camera animated:(BOOL)animated;
		[Export ("setCamera:animated:")]
		void SetCamera (MGLMapCamera camera, bool animated);

		// -(void)setCamera:(MGLMapCamera *)camera withDuration:(NSTimeInterval)duration animationTimingFunction:(CAMediaTimingFunction *)function;
		[Export ("setCamera:withDuration:animationTimingFunction:")]
		void SetCamera (MGLMapCamera camera, double duration, CAMediaTimingFunction function);

		// -(CLLocationCoordinate2D)convertPoint:(CGPoint)point toCoordinateFromView:(UIView *)view;
		[Export ("convertPoint:toCoordinateFromView:")]
		 ConvertPoint (CGPoint point, UIView view);

		// -(CGPoint)convertCoordinate:(CLLocationCoordinate2D)coordinate toPointToView:(UIView *)view;
		[Export ("convertCoordinate:toPointToView:")]
		CGPoint ConvertCoordinate ( coordinate, UIView view);

		// -(CLLocationDistance)metersPerPixelAtLatitude:(CLLocationDegrees)latitude;
		[Export ("metersPerPixelAtLatitude:")]
		double MetersPerPixelAtLatitude (double latitude);

		// -(BOOL)hasStyleClass:(NSString *)styleClass;
		[Export ("hasStyleClass:")]
		bool HasStyleClass (string styleClass);

		// -(void)addStyleClass:(NSString *)styleClass;
		[Export ("addStyleClass:")]
		void AddStyleClass (string styleClass);

		// -(void)removeStyleClass:(NSString *)styleClass;
		[Export ("removeStyleClass:")]
		void RemoveStyleClass (string styleClass);

		// -(void)addAnnotation:(id<MGLAnnotation>)annotation;
		[Export ("addAnnotation:")]
		void AddAnnotation (MGLAnnotation annotation);

		// -(void)addAnnotations:(NSArray *)annotations;
		[Export ("addAnnotations:")]
		void AddAnnotations (NSObject [] annotations);

		// -(void)removeAnnotation:(id<MGLAnnotation>)annotation;
		[Export ("removeAnnotation:")]
		void RemoveAnnotation (MGLAnnotation annotation);

		// -(void)removeAnnotations:(NSArray *)annotations;
		[Export ("removeAnnotations:")]
		void RemoveAnnotations (NSObject [] annotations);

		// -(MGLAnnotationImage *)dequeueReusableAnnotationImageWithIdentifier:(NSString *)identifier;
		[Export ("dequeueReusableAnnotationImageWithIdentifier:")]
		MGLAnnotationImage DequeueReusableAnnotationImageWithIdentifier (string identifier);

		// -(void)selectAnnotation:(id<MGLAnnotation>)annotation animated:(BOOL)animated;
		[Export ("selectAnnotation:animated:")]
		void SelectAnnotation (MGLAnnotation annotation, bool animated);

		// -(void)deselectAnnotation:(id<MGLAnnotation>)annotation animated:(BOOL)animated;
		[Export ("deselectAnnotation:animated:")]
		void DeselectAnnotation (MGLAnnotation annotation, bool animated);

		// -(void)addOverlay:(id<MGLOverlay>)overlay;
		[Export ("addOverlay:")]
		void AddOverlay (MGLOverlay overlay);

		// -(void)addOverlays:(NSArray *)overlays;
		[Export ("addOverlays:")]
		void AddOverlays (NSObject [] overlays);

		// -(void)removeOverlay:(id<MGLOverlay>)overlay;
		[Export ("removeOverlay:")]
		void RemoveOverlay (MGLOverlay overlay);

		// -(void)removeOverlays:(NSArray *)overlays;
		[Export ("removeOverlays:")]
		void RemoveOverlays (NSObject [] overlays);

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

	// @protocol MGLMapViewDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface MGLMapViewDelegate {

		// @optional -(NSString *)mapView:(MGLMapView *)mapView symbolNameForAnnotation:(id<MGLAnnotation>)annotation;
		[Availability (Unavailable = Platform.iOS | Platform.Mac)]
		[Export ("mapView:symbolNameForAnnotation:")]
		string SymbolNameForAnnotation (MGLMapView mapView, MGLAnnotation annotation);

		// @optional -(MGLAnnotationImage *)mapView:(MGLMapView *)mapView imageForAnnotation:(id<MGLAnnotation>)annotation;
		[Export ("mapView:imageForAnnotation:")]
		MGLAnnotationImage ImageForAnnotation (MGLMapView mapView, MGLAnnotation annotation);

		// @optional -(CGFloat)mapView:(MGLMapView *)mapView alphaForShapeAnnotation:(MGLShape *)annotation;
		[Export ("mapView:alphaForShapeAnnotation:")]
		nfloat AlphaForShapeAnnotation (MGLMapView mapView, MGLShape annotation);

		// @optional -(UIColor *)mapView:(MGLMapView *)mapView strokeColorForShapeAnnotation:(MGLShape *)annotation;
		[Export ("mapView:strokeColorForShapeAnnotation:")]
		UIColor StrokeColorForShapeAnnotation (MGLMapView mapView, MGLShape annotation);

		// @optional -(UIColor *)mapView:(MGLMapView *)mapView fillColorForPolygonAnnotation:(MGLPolygon *)annotation;
		[Export ("mapView:fillColorForPolygonAnnotation:")]
		UIColor FillColorForPolygonAnnotation (MGLMapView mapView, MGLPolygon annotation);

		// @optional -(CGFloat)mapView:(MGLMapView *)mapView lineWidthForPolylineAnnotation:(MGLPolyline *)annotation;
		[Export ("mapView:lineWidthForPolylineAnnotation:")]
		nfloat LineWidthForPolylineAnnotation (MGLMapView mapView, MGLPolyline annotation);

		// @optional -(BOOL)mapView:(MGLMapView *)mapView annotationCanShowCallout:(id<MGLAnnotation>)annotation;
		[Export ("mapView:annotationCanShowCallout:")]
		bool AnnotationCanShowCallout (MGLMapView mapView, MGLAnnotation annotation);

		// @optional -(UIView *)mapView:(MGLMapView *)mapView leftCalloutAccessoryViewForAnnotation:(id<MGLAnnotation>)annotation;
		[Export ("mapView:leftCalloutAccessoryViewForAnnotation:")]
		UIView LeftCalloutAccessoryViewForAnnotation (MGLMapView mapView, MGLAnnotation annotation);

		// @optional -(UIView *)mapView:(MGLMapView *)mapView rightCalloutAccessoryViewForAnnotation:(id<MGLAnnotation>)annotation;
		[Export ("mapView:rightCalloutAccessoryViewForAnnotation:")]
		UIView RightCalloutAccessoryViewForAnnotation (MGLMapView mapView, MGLAnnotation annotation);

		// @optional -(void)mapView:(MGLMapView *)mapView regionWillChangeAnimated:(BOOL)animated;
		[Export ("mapView:regionWillChangeAnimated:")]
		void RegionWillChangeAnimated (MGLMapView mapView, bool animated);

		// @optional -(void)mapViewRegionIsChanging:(MGLMapView *)mapView;
		[Export ("mapViewRegionIsChanging:")]
		void MapViewRegionIsChanging (MGLMapView mapView);

		// @optional -(void)mapView:(MGLMapView *)mapView regionDidChangeAnimated:(BOOL)animated;
		[Export ("mapView:regionDidChangeAnimated:")]
		void RegionDidChangeAnimated (MGLMapView mapView, bool animated);

		// @optional -(void)mapViewWillStartLoadingMap:(MGLMapView *)mapView;
		[Export ("mapViewWillStartLoadingMap:")]
		void MapViewWillStartLoadingMap (MGLMapView mapView);

		// @optional -(void)mapViewDidFinishLoadingMap:(MGLMapView *)mapView;
		[Export ("mapViewDidFinishLoadingMap:")]
		void MapViewDidFinishLoadingMap (MGLMapView mapView);

		// @optional -(void)mapViewDidFailLoadingMap:(MGLMapView *)mapView withError:(NSError *)error;
		[Export ("mapViewDidFailLoadingMap:withError:")]
		void WithError (MGLMapView mapView, NSError error);

		// @optional -(void)mapViewWillStartRenderingMap:(MGLMapView *)mapView;
		[Export ("mapViewWillStartRenderingMap:")]
		void MapViewWillStartRenderingMap (MGLMapView mapView);

		// @optional -(void)mapViewDidFinishRenderingMap:(MGLMapView *)mapView fullyRendered:(BOOL)fullyRendered;
		[Export ("mapViewDidFinishRenderingMap:fullyRendered:")]
		void FullyRendered (MGLMapView mapView, bool fullyRendered);

		// @optional -(void)mapViewWillStartRenderingFrame:(MGLMapView *)mapView;
		[Export ("mapViewWillStartRenderingFrame:")]
		void MapViewWillStartRenderingFrame (MGLMapView mapView);

		// @optional -(void)mapViewDidFinishRenderingFrame:(MGLMapView *)mapView fullyRendered:(BOOL)fullyRendered;
		[Export ("mapViewDidFinishRenderingFrame:fullyRendered:")]
		void FullyRendered (MGLMapView mapView, bool fullyRendered);

		// @optional -(void)mapViewWillStartLocatingUser:(MGLMapView *)mapView;
		[Export ("mapViewWillStartLocatingUser:")]
		void MapViewWillStartLocatingUser (MGLMapView mapView);

		// @optional -(void)mapViewDidStopLocatingUser:(MGLMapView *)mapView;
		[Export ("mapViewDidStopLocatingUser:")]
		void MapViewDidStopLocatingUser (MGLMapView mapView);

		// @optional -(void)mapView:(MGLMapView *)mapView didUpdateUserLocation:(MGLUserLocation *)userLocation;
		[Export ("mapView:didUpdateUserLocation:")]
		void DidUpdateUserLocation (MGLMapView mapView, MGLUserLocation userLocation);

		// @optional -(void)mapView:(MGLMapView *)mapView didFailToLocateUserWithError:(NSError *)error;
		[Export ("mapView:didFailToLocateUserWithError:")]
		void DidFailToLocateUserWithError (MGLMapView mapView, NSError error);

		// @optional -(void)mapView:(MGLMapView *)mapView didChangeUserTrackingMode:(MGLUserTrackingMode)mode animated:(BOOL)animated;
		[Export ("mapView:didChangeUserTrackingMode:animated:")]
		void DidChangeUserTrackingMode (MGLMapView mapView, MGLUserTrackingMode mode, bool animated);

		// @optional -(void)mapView:(MGLMapView *)mapView annotation:(id<MGLAnnotation>)annotation calloutAccessoryControlTapped:(UIControl *)control;
		[Export ("mapView:annotation:calloutAccessoryControlTapped:")]
		void Annotation (MGLMapView mapView, MGLAnnotation annotation, UIControl control);

		// @optional -(void)mapView:(MGLMapView *)mapView didSelectAnnotation:(id<MGLAnnotation>)annotation;
		[Export ("mapView:didSelectAnnotation:")]
		void DidSelectAnnotation (MGLMapView mapView, MGLAnnotation annotation);

		// @optional -(void)mapView:(MGLMapView *)mapView didDeselectAnnotation:(id<MGLAnnotation>)annotation;
		[Export ("mapView:didDeselectAnnotation:")]
		void DidDeselectAnnotation (MGLMapView mapView, MGLAnnotation annotation);
	}

	// @interface MGLShape : NSObject <MGLAnnotation>
	[BaseType (typeof (NSObject))]
	interface MGLShape : MGLAnnotation {

		// @property (copy, nonatomic) NSString * title;
		[Export ("title")]
		string Title { get; set; }

		// @property (copy, nonatomic) NSString * subtitle;
		[Export ("subtitle")]
		string Subtitle { get; set; }
	}

	// @interface MGLMultiPoint : MGLShape
	[BaseType (typeof (MGLShape))]
	interface MGLMultiPoint {

		// @property (readonly, nonatomic) NSUInteger pointCount;
		[Export ("pointCount")]
		nuint PointCount { get; }

		// -(void)getCoordinates:(CLLocationCoordinate2D *)coords range:(NSRange)range;
		[Export ("getCoordinates:range:")]
		void GetCoordinates ( coords, _NSRange range);
	}

	// @protocol MGLOverlay <MGLAnnotation>
	[Protocol, Model]
	interface MGLOverlay : MGLAnnotation {

		// @property (readonly, nonatomic) CLLocationCoordinate2D coordinate;
		[Export ("coordinate")]
		 Coordinate { get; }

		// @property (readonly, nonatomic) MGLCoordinateBounds overlayBounds;
		[Export ("overlayBounds")]
		 OverlayBounds { get; }

		// @required -(BOOL)intersectsOverlayBounds:(MGLCoordinateBounds)overlayBounds;
		[Export ("intersectsOverlayBounds:")]
		[Abstract]
		bool IntersectsOverlayBounds ( overlayBounds);
	}

	// @interface MGLPointAnnotation : MGLShape
	[BaseType (typeof (MGLShape))]
	interface MGLPointAnnotation {

		// @property (assign, nonatomic) CLLocationCoordinate2D coordinate;
		[Export ("coordinate", ArgumentSemantic.UnsafeUnretained)]
		 Coordinate { get; set; }
	}

	// @interface MGLPolygon : MGLMultiPoint <MGLOverlay>
	[BaseType (typeof (MGLMultiPoint))]
	interface MGLPolygon : MGLOverlay {

		// +(instancetype)polygonWithCoordinates:(CLLocationCoordinate2D *)coords count:(NSUInteger)count;
		[Static, Export ("polygonWithCoordinates:count:")]
		MGLPolygon PolygonWithCoordinates ( coords, nuint count);
	}

	// @interface MGLPolyline : MGLMultiPoint <MGLOverlay>
	[BaseType (typeof (MGLMultiPoint))]
	interface MGLPolyline : MGLOverlay {

		// +(instancetype)polylineWithCoordinates:(CLLocationCoordinate2D *)coords count:(NSUInteger)count;
		[Static, Export ("polylineWithCoordinates:count:")]
		MGLPolyline PolylineWithCoordinates ( coords, nuint count);
	}

	// @interface MGLUserLocation : NSObject <MGLAnnotation>
	[BaseType (typeof (NSObject))]
	interface MGLUserLocation : MGLAnnotation {

		// @property (readonly, nonatomic) CLLocation * location;
		[Export ("location")]
		CLLocation Location { get; }

		// @property (readonly, nonatomic, getter = isUpdating) BOOL updating;
		[Export ("updating")]
		bool Updating { [Bind ("isUpdating")] get; }

		// @property (readonly, nonatomic) CLHeading * heading;
		[Export ("heading")]
		CLHeading Heading { get; }

		// @property (copy, nonatomic) NSString * title;
		[Export ("title")]
		string Title { get; set; }

		// @property (copy, nonatomic) NSString * subtitle;
		[Export ("subtitle")]
		string Subtitle { get; set; }
	}
}
