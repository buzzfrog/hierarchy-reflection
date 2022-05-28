# hierarchy-reflection
An example that combines Reflection, Extension Methods and custom Attributes to traverse a hierarchy

## Problem
I have a hierarchy structure of objects that doesn't implement 
the same interface. This means that the "children" property return
a concrete list `List<Beta>` instead of `List<BaseModel>`. 

How can I traverse such hierarchy?

## Solution
* Created a custom attribute `[Children]` that define the "children" property.
* Use Reflection to read the attribute and return the properties.
* Use an Extension Method to get information about the object. 