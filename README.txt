
--------------------------
Additional areas to expand
==========================

* Allow rules to be read in from any format and not just specified in code.

e.g.  XML

<rules>
  <add key="3" value="fizz" />
  <add key="5" value="buzz" />
</rules>

e.g.  JSON

[
{ key: 3, value: "fizz" },
{ key: 5, value: "buzz" }
]

* Expose this logic to outside components using a RESTful Web API service or an implementation with WCF.