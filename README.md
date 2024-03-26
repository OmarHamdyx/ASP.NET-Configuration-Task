ASP.NET Core Configuration Demo
===============================

This project demonstrates the usage of configuration in ASP.NET Core to display social media links based on environment-specific settings.

Instructions
------------

*   Create controller(s) with attribute routing.
*   Provide the configuration as a service using the Options pattern.
*   Inject the IOptions in the controller and supply social media links to the view via ViewBag.
*   Use CSS styles, layout views, \_ViewImports, \_ViewStart as per necessity.

Configuration Details
---------------------

The social media links are stored in the following configuration files:

*   **appsettings.json:** Default configuration for all environments.
*   **appsettings.Development.json:** Configuration specific to the Development environment.

View Output
-----------

The view will display social media links based on the environment:

*   **For any other environment:** Display links as provided in appsettings.json.
*   **For Development environment:** Display links as provided in appsettings.Development.json.
