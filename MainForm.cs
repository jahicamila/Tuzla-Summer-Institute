/*
 * Created by SharpDevelop.
 * User: Dell
 * Date: 7.7.2022.
 * Time: 13:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace calculator
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		double prviBroj=0;
		string prethodniOperator="";
		double rezultat=0;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void Button1Click(object sender, EventArgs e)
		{
			
			if(isTextEqualToZero(result.Text)){
				result.Text="";
			}
			result.Text += digit1.Text;
			
			
		}
		
		void Digit2Click(object sender, EventArgs e)
		{
			
			if(isTextEqualToZero(result.Text)){
				result.Text="";
			}
			result.Text += digit2.Text;
			
			
		}
		
		void Digit3Click(object sender, EventArgs e)
		{
			
			if(isTextEqualToZero(result.Text)){
				result.Text="";
			}
			result.Text += digit3.Text;
			
		}
		
		void Digit4Click(object sender, EventArgs e)
		{
			
			if(isTextEqualToZero(result.Text)){
				result.Text="";
			}
			result.Text += digit4.Text;
			
		}
		
		void Digit5Click(object sender, EventArgs e)
		{
			
			if(isTextEqualToZero(result.Text)){
				result.Text="";
			}
			result.Text += digit5.Text;
			
			
		}
		
		void Digit6Click(object sender, EventArgs e)
		{
			
			if(isTextEqualToZero(result.Text)){
				result.Text="";
			}
			result.Text += digit6.Text;
			
			
		}
		
		void Digit7Click(object sender, EventArgs e)
		{
			
			
			if(isTextEqualToZero(result.Text)){
				result.Text="";
			}
			result.Text += digit7.Text;
			
		}
		
		void Digit8Click(object sender, EventArgs e)
		{
			if(isTextEqualToZero(result.Text)){
				result.Text="";
			}
			result.Text += digit8.Text;
			
		}
		
		void Digit9Click(object sender, EventArgs e)
		{
			if(isTextEqualToZero(result.Text)){
				result.Text="";
			}
			result.Text += digit9.Text;
			
		}
		
		bool isTextEqualToZero(string rez)
		{
			if(rez == "0"){
				return true;
			}
			return false;
		}
		
		void DottClick(object sender, EventArgs e)
		{
			if(isTextEqualToZero(result.Text)){
				result.Text="";
			}
			result.Text+=dott.Text;	
			}
			
		
		void PlusClick(object sender, EventArgs e)
		{
			prviBroj=double.Parse(result.Text);
			prethodniOperator="+";
			result.Text="0";
			
			
		}
		
		void MinusClick(object sender, EventArgs e)
		{
		prviBroj=double.Parse(result.Text);
			prethodniOperator="-";
			result.Text="0";
			
		}
		
		void MultiplyClick(object sender, EventArgs e)
		{
			prviBroj=double.Parse(result.Text);
			prethodniOperator="*";
			result.Text="0";
			
		}
		
		void DivideClick(object sender, EventArgs e)
		{
			prviBroj=double.Parse(result.Text);
			prethodniOperator="/";
			result.Text="0";
			
		}
		
		void EqualClick(object sender, EventArgs e)
		{
			double drugiBroj=double.Parse(result.Text);
			
			switch(prethodniOperator){
			case "+":
				rezultat=prviBroj+drugiBroj;
				prviBroj=0;
				drugiBroj=0;
				break;
			case "-":
				rezultat=prviBroj-drugiBroj;
				prviBroj=0;
				drugiBroj=0;
				break;
			case "*":
				rezultat=prviBroj*drugiBroj;
				prviBroj=0;
				drugiBroj=0;
				break;
			case "/":
				rezultat=prviBroj/drugiBroj;
				prviBroj=0;
				drugiBroj=0;
				break;
				
				
			}
			result.Text=Convert.ToString(rezultat);
		}
		
		void Digit0Click(object sender, EventArgs e)
		{
			if(isTextEqualToZero(result.Text)){
				result.Text="";
			}
			result.Text += digit0.Text;
		}
		}
	}

