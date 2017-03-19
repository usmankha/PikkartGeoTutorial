using System;
using UIKit;
using Pikkart.ArSdk.Geo;
using System.Collections.Generic;
using CoreLocation;

namespace PikkartGeoTutorial.iOS
{
	public partial class ViewController : PKTGeoMainController
	{
		
		public ViewController():base() {}
		
		public ViewController(PKTMarkerViewAdapter  geoAdapter, 
							  PKTMarkerViewAdapter	mapAdapter):base(geoAdapter, mapAdapter) {}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			Dictionary<string, CLLocation> poiNames=new Dictionary<string, CLLocation>();
			PKTGeoLocation geoLocation;
			PKTGeoElement geoElement;
			List<PKTGeoElement> geoElements=new List<PKTGeoElement>();
			
			poiNames.Add("Scala, Milano",new CLLocation(45.466019,9.188020));
			poiNames.Add("Rione II Trevi, Roma",new CLLocation(41.903598,12.476896));
			poiNames.Add("Modena, Circoscrizione 1",new CLLocation(44.647225,10.924819));
        	var index = 0;
        	foreach (var pair in poiNames)  {
           		geoLocation = new PKTGeoLocation(pair.Value.Coordinate.Latitude, pair.Value.Coordinate.Longitude,0);
           		geoElement = new PKTGeoElement(geoLocation, index+pair.Key, "");
           		geoElements.Add(geoElement);
           		index = index + 1;
        	}
        	Show(geoElements.ToArray());
		}
		
		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
			
		}
		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.		
		}
	}
}
