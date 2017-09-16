# ShapedButtonXamarin
ShapedButton is a subclass of UIButton transformed for non-rectangular button shapes. Instances of ShapedButton respond to touches only in areas where the image that is assigned to the button for UIControlStateNormal is non-transparent.

<table>
<tr>
<td width="24.5%" valign="top" align="justify">
<img src="https://github.com/XamCoderr/ShapedButtonXamarin/blob/master/Screenshots/ShapedButton.gif">
</td>
</tr>
</table>


## Usage
-----
* Create instance if Shaped Button just like UIButton and configure it's properties.
* Also have includes support for IB and iOS designer. 
* For IB support, Design your UI in Interface Builder with UIButtons as usual. Set the Button type to Custom
  and provide transparent PNG images for the different control states as needed.
* In the Identity Inspector in Interface Builder, set the Class of the button to `ShapedButton`.
  That's it! Your button will now only respond to touches where the PNG image for the normal
  control state is non-transparent.

Inspired from ObjectiveC Library https://github.com/ole/OBShapedButton


## Compatibility

iOS 7,
iOS 8,
iOS 9,
iOS 10

## License

Copyright 2017, XamCoderr

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
