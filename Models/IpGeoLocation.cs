public class IpGeoLocation {
    public String success;
    public String country;
    public String countryCode;
    public String region;
    public String regionName;
    public String city;
    public String zip;
    public double lat;
    public double lon;
    public String timezone;
    public String isp;

    public IpGeoLocation(
            String success,
            String country,
            String countryCode,
            String region,
            String regionName,
            String city,
            String zip,
            double lat,
            double lon,
            String timezone,
            String isp
    ) {
        this.success = success;
        this.country = country;
        this.countryCode = countryCode;
        this.region = region;
        this.regionName = regionName;
        this.city = city;
        this.zip = zip;
        this.lat = lat;
        this.lon = lon;
        this.timezone = timezone;
        this.isp = isp;
    }
}