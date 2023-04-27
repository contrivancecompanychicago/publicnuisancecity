import { Mapbox, MapboxMap, Style } from "mapbox-gl";

const foodDesertsGeojson = `
{
  "type": "FeatureCollection",
  "features": [
    {
      "type": "Feature",
      "geometry": {
        "type": "Point",
        "coordinates": [
          41.8781,
          -87.6231
        ]
      },
      "properties": {
        "name": "Food Desert 1"
      }
    },
    {
      "type": "Feature",
      "geometry": {
        "type": "Point",
        "coordinates": [
          41.8881,
          -87.6331
        ]
      },
      "properties": {
        "name": "Food Desert 2"
      }
    }
  ]
}
`;

const mapboxAccessToken = "YOUR_MAPBOX_ACCESS_TOKEN";

const map = new Mapbox(
  "YOUR_MAPBOX_STYLE_ID",
  {
    accessToken: mapboxAccessToken,
    bearing: 0,
    pitch: 0,
    zoom: 10,
    center: [41.8781, -87.6231]
  }
);

map.addLayer({
  id: "food-deserts",
  type: "line",
  source: "geojson",
  data: foodDesertsGeojson,
  style: {
    lineColor: "#ff0000",
    lineWidth: 2
  }
});

map.addLayer({
  id: "markers",
  type: "symbol",
  source: "geojson",
  data: foodDesertsGeojson,
  style: {
    symbol: "circle",
    circleSize: 10,
    circleColor: "#ff0000"
  }
});

map.on("click", "markers", (e) => {
  console.log(e.features[0].properties.name);
});

map.addControl(new MapboxGL.NavigationControl());

map.addControl(new MapboxGL.FullscreenControl());

map.addControl(new MapboxGL.ScaleControl());

map.addControl(new MapboxGL.GeolocateControl());

map.addControl(new MapboxGL.AttributionControl());

map.on("load", () => {
  console.log("Map loaded");
});
