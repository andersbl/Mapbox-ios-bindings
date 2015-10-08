# Mapbox-ios-bindings


Not all bindings are available!! 


usage: 

1: 

in the info.plist set two new keys  MGLMapboxAccessToken  with your access token and MGLMapboxMetricsEnabledSettingShownInApp to either yes or no. 

2: create a new UIViewController

3: example code 

	MGLMapView mapView;


		public override void ViewDidLoad()
		{

			base.ViewDidLoad();

			mapView = new MGLMapView (View.Bounds);
			mapView.CenterCoordinate = new CoreLocation.CLLocationCoordinate2D (55.6495,12.5424);

			View.AddSubview (mapView);
			mapView.SetZoomLevel (16,false );
		}
