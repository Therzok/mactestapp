﻿using System;

using AppKit;
using CoreGraphics;
using Foundation;

namespace mactestapp {
	public partial class ViewController : NSViewController {
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

            var panel = new NSSavePanel();
            panel.DidChangeToDirectory += (o, args) => {
                var url = args.NewDirectoryUrl;
                Console.WriteLine(url.Path);
            };

            View.AddSubview(NSButton.CreateButton("a", () => panel.RunModal()));

			// Do any additional setup after loading the view.
		}

		public override NSObject RepresentedObject {
			get {
				return base.RepresentedObject;
			}
			set {
				base.RepresentedObject = value;
				// Update the view, if already loaded.
			}
		}
	}
}
