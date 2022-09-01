syntax = "proto3";

package protocolor;

//Services define the different communication scenarios available
//A simple service for generating color
service ColorGenerator {
    //Generates a random color on each request
    rpc GetRandomColor (CurrentColor) returns (NewColor) {}
}

// Messages define the data format
message CurrentColor {
    string color = 1;
}

message NewColor {
    string color = 1;
}
