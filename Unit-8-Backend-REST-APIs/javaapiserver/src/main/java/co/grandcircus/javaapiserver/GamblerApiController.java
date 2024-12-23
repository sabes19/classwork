package co.grandcircus.javaapiserver;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;


@RestController                         // Tells SB this class contains REST API Controllers
public class GamblerApiController {
    // Simple controller to test our setup
    @GetMapping("/")                        // Handle the HTTP Get request for route path "/"
    public String testMethod() {
        return "Call to Route path successfully";
    }
   
    

}
