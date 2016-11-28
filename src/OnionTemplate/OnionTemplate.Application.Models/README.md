# Application Models	

This section defines our application models. These models include input, output, and transfer objects. 
These can be used to map Data objects to more manageable types.

This project should only reference Domain Models and should avoid any other references or packages not required for defining application layer models

NOTE: These models CAN be observable so that at runtime, the UI updates when this model updates. These however are NOT ViewModels for an entire page. These still represent data, but can be observable.