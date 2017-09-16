using System;
using CoreGraphics;
using UIKit;

namespace ShapedButtonDemo
{
	public class UIImage_ColorAtPixel
	{
		public UIImage_ColorAtPixel ()
		{
		}

		public static UIColor ColorAtPixel (CGPoint point, UIImage image)
		{
			CGRect rect = new CGRect (0, 0, image.Size.Width, image.Size.Height);
			// CancelIf pointIs outside Image coordinates
			if (!rect.Contains (point)) {
				return null;
			}

			// Create a 1x1 pixel byte array and bitmap context to draw the pixelInto.
			// Reference: http://stackoverflow.com/questions/1042830/retrieving-a-pixel-alpha-value-for-a-uiImage
			int pointX = Convert.ToInt16 (Math.Truncate (point.X));
			int pointY = Convert.ToInt16 (Math.Truncate (point.Y));
			CGImage cgimage = image.CGImage;
			int width = Convert.ToInt16 (image.Size.Width);
			int height = Convert.ToInt16 (image.Size.Height);
			CGColorSpace colorSpace = CGColorSpace.CreateDeviceRGB ();
			int bytesPerPixel = 4;
			int bytesPerRow = bytesPerPixel * 1;
			int bitsPerComponent = 8;
			byte[] pixelData = { 0, 0, 0, 0 };
			CGContext context = new CGBitmapContext (pixelData, 
				                    1,
				                    1,
				                    bitsPerComponent, 
				                    bytesPerRow, 
				                    colorSpace,
				                    CGImageAlphaInfo.PremultipliedLast /*| CGBitmapFlags.ByteOrder32Big*/);
			
//			colorSpace.Dispose ();
			context.SetFillColorSpace (colorSpace); //    CGColorSpaceRelease(colorSpace); //TODO Not Sure
			context.SetBlendMode (CGBlendMode.Copy);

			// Draw the pixel we areInterestedIn onto the bitmap context
			context.TranslateCTM (-pointX, pointY - (nfloat)height);
			context.DrawImage (new CGRect (0.0f, 0.0f, (nfloat)width, (nfloat)height), image.CGImage);
			context.Dispose ();  // CGContextRelease(context); //TODO Not Sure
		
			// Convert color values [0..255] to floats [0.0..1.0]
			nfloat red = (nfloat)pixelData [0] / 255.0f;
			nfloat green = (nfloat)pixelData [1] / 255.0f;
			nfloat blue = (nfloat)pixelData [2] / 255.0f;
			nfloat alpha = (nfloat)pixelData [3] / 255.0f;
			return UIColor.FromRGBA (red, green, blue, alpha);
		}

	}
}

