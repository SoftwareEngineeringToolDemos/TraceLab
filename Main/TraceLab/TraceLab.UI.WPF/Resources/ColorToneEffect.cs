﻿// TraceLab - Software Traceability Instrument to Facilitate and Empower Traceability Research
// Copyright (C) 2012-2013 CoEST - National Science Foundation MRI-R2 Grant # CNS: 0959924
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see<http://www.gnu.org/licenses/>.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Media3D;


namespace TraceLab.UI.WPF.Resources {
	
	/// <summary>An effect that blends between partial desaturation and a two-color ramp.</summary>
	public class ColorToneEffect : ShaderEffect {
		public static readonly DependencyProperty InputProperty = ShaderEffect.RegisterPixelShaderSamplerProperty("Input", typeof(ColorToneEffect), 0);
		public static readonly DependencyProperty DesaturationProperty = DependencyProperty.Register("Desaturation", typeof(double), typeof(ColorToneEffect), new UIPropertyMetadata(((double)(0.5D)), PixelShaderConstantCallback(0)));
		public static readonly DependencyProperty TonedProperty = DependencyProperty.Register("Toned", typeof(double), typeof(ColorToneEffect), new UIPropertyMetadata(((double)(0.5D)), PixelShaderConstantCallback(1)));
		public static readonly DependencyProperty LightColorProperty = DependencyProperty.Register("LightColor", typeof(Color), typeof(ColorToneEffect), new UIPropertyMetadata(Color.FromArgb(255, 255, 255, 0), PixelShaderConstantCallback(2)));
		public static readonly DependencyProperty DarkColorProperty = DependencyProperty.Register("DarkColor", typeof(Color), typeof(ColorToneEffect), new UIPropertyMetadata(Color.FromArgb(255, 0, 0, 128), PixelShaderConstantCallback(3)));
		public ColorToneEffect() {
			PixelShader pixelShader = new PixelShader();
            pixelShader.UriSource = new Uri("/TraceLab.UI.WPF;component/Resources/ColorTone.ps", UriKind.Relative);
			this.PixelShader = pixelShader;

			this.UpdateShaderValue(InputProperty);
			this.UpdateShaderValue(DesaturationProperty);
			this.UpdateShaderValue(TonedProperty);
			this.UpdateShaderValue(LightColorProperty);
			this.UpdateShaderValue(DarkColorProperty);
		}
		public Brush Input {
			get {
				return ((Brush)(this.GetValue(InputProperty)));
			}
			set {
				this.SetValue(InputProperty, value);
			}
		}
		/// <summary>The amount of desaturation to apply.</summary>
		public double Desaturation {
			get {
				return ((double)(this.GetValue(DesaturationProperty)));
			}
			set {
				this.SetValue(DesaturationProperty, value);
			}
		}
		/// <summary>The amount of color toning to apply.</summary>
		public double Toned {
			get {
				return ((double)(this.GetValue(TonedProperty)));
			}
			set {
				this.SetValue(TonedProperty, value);
			}
		}
		/// <summary>The first color to apply to input. This is usually a light tone.</summary>
		public Color LightColor {
			get {
				return ((Color)(this.GetValue(LightColorProperty)));
			}
			set {
				this.SetValue(LightColorProperty, value);
			}
		}
		/// <summary>The second color to apply to the input. This is usuall a dark tone.</summary>
		public Color DarkColor {
			get {
				return ((Color)(this.GetValue(DarkColorProperty)));
			}
			set {
				this.SetValue(DarkColorProperty, value);
			}
		}
	}
}
