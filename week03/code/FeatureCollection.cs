public class FeatureCollection {
    // Todo Earthquake Problem - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public Feature[] Features { get; set; }
}

public class Feature {
    public Properties Properties { get; set; }
}

public class Properties {
    public string Place { get; set; }
    public double Magnitude { get; set; }
}