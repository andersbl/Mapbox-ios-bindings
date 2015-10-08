using System;
using ObjCRuntime;
using CoreLocation;


namespace MapBoxIOS {

	[Native]
	public enum MGLUserTrackingMode : ulong /* nuint */ {
		None = 0,
		Follow,
		FollowWithHeading,
		FollowWithCourse
	}
	public struct MGLCoordinateBounds {
		CLLocationCoordinate2D sw;
		CLLocationCoordinate2D ne;

	}
}
