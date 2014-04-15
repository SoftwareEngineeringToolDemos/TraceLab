//
// FloatRange.cs
//
// Author:
//   Lluis Sanchez Gual
//
// Copyright (C) 2007 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.ComponentModel;

namespace MonoDevelop.Components.PropertyGrid.PropertyEditors
{
	[PropertyEditorType (typeof (Double))]
	[PropertyEditorType (typeof (Single))]
	public class FloatRange : Gtk.SpinButton, IPropertyEditor
	{
		Type propType;
		
		public FloatRange (): base (0, 0, 0.01)
		{
		}
		
		public void Initialize (EditSession session)
		{
			propType = session.Property.PropertyType;
			
			double min, max;
			
			if (propType == typeof(double)) {
				min = Double.MinValue;
				max = Double.MaxValue;
			} else if (propType == typeof(float)) {
				min = float.MinValue;
				max = float.MaxValue;
			} else
				throw new ApplicationException ("FloatRange editor does not support editing values of type " + propType);
			
			SetRange (min, max);
			
			Digits = 2;
		}
		
		object IPropertyEditor.Value {
			get { return Convert.ChangeType (base.Value, propType); }
			set { base.Value = (double) Convert.ChangeType (value, typeof(double)); }
		}
	}
}
