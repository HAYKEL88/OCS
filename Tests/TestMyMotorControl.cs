/*
 * Crée par SharpDevelop.
 * Utilisateur: OUHICHI
 * Date: 25/12/2014
 * Heure: 20:37
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

using WComp.Beans;

namespace DefaultNamespace
{
	/// <summary>
	/// Description of Container1.
	/// </summary>
	public class Container1 : System.Windows.Forms.Form
	{
        [BeanDesignLocation(592,192)]
        private WComp.Beans.MyMotorControlBean myMotorControlBean1;
        [BeanDesignLocation(176,72)]
        private System.Windows.Forms.Button button1;
        [BeanDesignLocation(176,152)]
        private System.Windows.Forms.Button button2;
        [BeanDesignLocation(160,320)]
        private System.Windows.Forms.TrackBar trackBar1;
		public Container1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			//
			// The InitializeBeans() call is required for WComp.NET designer support.
			//
			InitializeBeans();
			
			//
			// TODO: Add constructor code after the InitializeBeans() call.
			//
		}
		
		[STAThread]
		public static void Main(string[] args)
		{
			Application.Run(new Container1());
		}
		
		#region WComp.NET designer generated code
		/// <summary>
		/// This method is required for WComp.NET designer support.
		/// Do not change the method contents inside the source code editor.
		/// The WComp.NET designer might not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent() {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            // 
            // button1
            // 
            this.button1.Text = "Start";
            this.button1.Controls = null;
            this.button1.DataBindings = null;
            this.button1.Location = new System.Drawing.Point(176, 72);
            // 
            // button2
            // 
            this.button2.Text = "Stop";
            this.button2.Controls = null;
            this.button2.DataBindings = null;
            this.button2.Location = new System.Drawing.Point(176, 152);
            // 
            // trackBar1
            // 
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = -100;
            this.trackBar1.Controls = null;
            this.trackBar1.DataBindings = null;
            this.trackBar1.Location = new System.Drawing.Point(160, 320);
            // 
            // TestMyMotorControl
            // 
            this.Text = "SharpWComp static application";
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.trackBar1);
        }
		
		/// <summary>
		/// This method is required for WComp.NET designer support.
		/// Do not change the method contents inside the source code editor.
		/// The WComp.NET designer might not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeBeans() {
            this.myMotorControlBean1 = new WComp.Beans.MyMotorControlBean();
            // 
            Control.CheckForIllegalCrossThreadCalls = false;
            // 
            // Event dispatching
            // 
            this.button1.Click += new System.EventHandler(this.@__button1_to_myMotorControlBean1_0);
            this.button2.Click += new System.EventHandler(this.@__button2_to_myMotorControlBean1_1);
            this.trackBar1.ValueChanged += new System.EventHandler(this.@__trackBar1_to_myMotorControlBean1_2);
        }

		private void @__button1_to_myMotorControlBean1_0(object sender, System.EventArgs e) {
            this.myMotorControlBean1.loadMotorControl();
        }

		private void @__button2_to_myMotorControlBean1_1(object sender, System.EventArgs e) {
            this.myMotorControlBean1.stopMotorControl();
        }

		private void @__trackBar1_to_myMotorControlBean1_2(object sender, System.EventArgs e) {
            this.myMotorControlBean1.setVelocity(this.trackBar1.Value);
        }
		#endregion
	}
}
