using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jeesoft.Widget.Pickerview {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R']"
	[global::Android.Runtime.Register ("cn/jeesoft/widget/pickerview/R", DoNotGenerateAcw=true)]
	public sealed partial class R : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R.anim']"
		[global::Android.Runtime.Register ("cn/jeesoft/widget/pickerview/R$anim", DoNotGenerateAcw=true)]
		public sealed partial class Anim : global::Java.Lang.Object {


			static IntPtr j_anim_enter_bottom_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R.anim']/field[@name='j_anim_enter_bottom']"
			[Register ("j_anim_enter_bottom")]
			public static int JAnimEnterBottom {
				get {
					if (j_anim_enter_bottom_jfieldId == IntPtr.Zero)
						j_anim_enter_bottom_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_anim_enter_bottom", "I");
					return JNIEnv.GetStaticIntField (class_ref, j_anim_enter_bottom_jfieldId);
				}
				set {
					if (j_anim_enter_bottom_jfieldId == IntPtr.Zero)
						j_anim_enter_bottom_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_anim_enter_bottom", "I");
					try {
						JNIEnv.SetStaticField (class_ref, j_anim_enter_bottom_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr j_anim_exit_bottom_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R.anim']/field[@name='j_anim_exit_bottom']"
			[Register ("j_anim_exit_bottom")]
			public static int JAnimExitBottom {
				get {
					if (j_anim_exit_bottom_jfieldId == IntPtr.Zero)
						j_anim_exit_bottom_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_anim_exit_bottom", "I");
					return JNIEnv.GetStaticIntField (class_ref, j_anim_exit_bottom_jfieldId);
				}
				set {
					if (j_anim_exit_bottom_jfieldId == IntPtr.Zero)
						j_anim_exit_bottom_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_anim_exit_bottom", "I");
					try {
						JNIEnv.SetStaticField (class_ref, j_anim_exit_bottom_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("cn/jeesoft/widget/pickerview/R$anim", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Anim); }
			}

			internal Anim (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R.anim']/constructor[@name='R.anim' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Anim ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Anim)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R.attr']"
		[global::Android.Runtime.Register ("cn/jeesoft/widget/pickerview/R$attr", DoNotGenerateAcw=true)]
		public sealed partial class Attr : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("cn/jeesoft/widget/pickerview/R$attr", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Attr); }
			}

			internal Attr (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R.attr']/constructor[@name='R.attr' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Attr ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Attr)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R.color']"
		[global::Android.Runtime.Register ("cn/jeesoft/widget/pickerview/R$color", DoNotGenerateAcw=true)]
		public sealed partial class Color : global::Java.Lang.Object {


			static IntPtr j_wheel_timebtn_nor_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R.color']/field[@name='j_wheel_timebtn_nor']"
			[Register ("j_wheel_timebtn_nor")]
			public static int JWheelTimebtnNor {
				get {
					if (j_wheel_timebtn_nor_jfieldId == IntPtr.Zero)
						j_wheel_timebtn_nor_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_wheel_timebtn_nor", "I");
					return JNIEnv.GetStaticIntField (class_ref, j_wheel_timebtn_nor_jfieldId);
				}
				set {
					if (j_wheel_timebtn_nor_jfieldId == IntPtr.Zero)
						j_wheel_timebtn_nor_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_wheel_timebtn_nor", "I");
					try {
						JNIEnv.SetStaticField (class_ref, j_wheel_timebtn_nor_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr j_wheel_timebtn_pre_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R.color']/field[@name='j_wheel_timebtn_pre']"
			[Register ("j_wheel_timebtn_pre")]
			public static int JWheelTimebtnPre {
				get {
					if (j_wheel_timebtn_pre_jfieldId == IntPtr.Zero)
						j_wheel_timebtn_pre_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_wheel_timebtn_pre", "I");
					return JNIEnv.GetStaticIntField (class_ref, j_wheel_timebtn_pre_jfieldId);
				}
				set {
					if (j_wheel_timebtn_pre_jfieldId == IntPtr.Zero)
						j_wheel_timebtn_pre_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_wheel_timebtn_pre", "I");
					try {
						JNIEnv.SetStaticField (class_ref, j_wheel_timebtn_pre_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("cn/jeesoft/widget/pickerview/R$color", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Color); }
			}

			internal Color (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R.color']/constructor[@name='R.color' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Color ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Color)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R.drawable']"
		[global::Android.Runtime.Register ("cn/jeesoft/widget/pickerview/R$drawable", DoNotGenerateAcw=true)]
		public sealed partial class Drawable : global::Java.Lang.Object {


			static IntPtr j_bg_above_timepicker_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R.drawable']/field[@name='j_bg_above_timepicker']"
			[Register ("j_bg_above_timepicker")]
			public static int JBgAboveTimepicker {
				get {
					if (j_bg_above_timepicker_jfieldId == IntPtr.Zero)
						j_bg_above_timepicker_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_bg_above_timepicker", "I");
					return JNIEnv.GetStaticIntField (class_ref, j_bg_above_timepicker_jfieldId);
				}
				set {
					if (j_bg_above_timepicker_jfieldId == IntPtr.Zero)
						j_bg_above_timepicker_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_bg_above_timepicker", "I");
					try {
						JNIEnv.SetStaticField (class_ref, j_bg_above_timepicker_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr j_bg_line_timepicker_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R.drawable']/field[@name='j_bg_line_timepicker']"
			[Register ("j_bg_line_timepicker")]
			public static int JBgLineTimepicker {
				get {
					if (j_bg_line_timepicker_jfieldId == IntPtr.Zero)
						j_bg_line_timepicker_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_bg_line_timepicker", "I");
					return JNIEnv.GetStaticIntField (class_ref, j_bg_line_timepicker_jfieldId);
				}
				set {
					if (j_bg_line_timepicker_jfieldId == IntPtr.Zero)
						j_bg_line_timepicker_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_bg_line_timepicker", "I");
					try {
						JNIEnv.SetStaticField (class_ref, j_bg_line_timepicker_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr j_wheel_timebtn_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R.drawable']/field[@name='j_wheel_timebtn']"
			[Register ("j_wheel_timebtn")]
			public static int JWheelTimebtn {
				get {
					if (j_wheel_timebtn_jfieldId == IntPtr.Zero)
						j_wheel_timebtn_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_wheel_timebtn", "I");
					return JNIEnv.GetStaticIntField (class_ref, j_wheel_timebtn_jfieldId);
				}
				set {
					if (j_wheel_timebtn_jfieldId == IntPtr.Zero)
						j_wheel_timebtn_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_wheel_timebtn", "I");
					try {
						JNIEnv.SetStaticField (class_ref, j_wheel_timebtn_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr j_wheel_val_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R.drawable']/field[@name='j_wheel_val']"
			[Register ("j_wheel_val")]
			public static int JWheelVal {
				get {
					if (j_wheel_val_jfieldId == IntPtr.Zero)
						j_wheel_val_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_wheel_val", "I");
					return JNIEnv.GetStaticIntField (class_ref, j_wheel_val_jfieldId);
				}
				set {
					if (j_wheel_val_jfieldId == IntPtr.Zero)
						j_wheel_val_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_wheel_val", "I");
					try {
						JNIEnv.SetStaticField (class_ref, j_wheel_val_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("cn/jeesoft/widget/pickerview/R$drawable", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Drawable); }
			}

			internal Drawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R.drawable']/constructor[@name='R.drawable' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Drawable ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Drawable)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R.id']"
		[global::Android.Runtime.Register ("cn/jeesoft/widget/pickerview/R$id", DoNotGenerateAcw=true)]
		public sealed partial class Id : global::Java.Lang.Object {


			static IntPtr j_btnCancel_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R.id']/field[@name='j_btnCancel']"
			[Register ("j_btnCancel")]
			public static int JBtnCancel {
				get {
					if (j_btnCancel_jfieldId == IntPtr.Zero)
						j_btnCancel_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_btnCancel", "I");
					return JNIEnv.GetStaticIntField (class_ref, j_btnCancel_jfieldId);
				}
				set {
					if (j_btnCancel_jfieldId == IntPtr.Zero)
						j_btnCancel_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_btnCancel", "I");
					try {
						JNIEnv.SetStaticField (class_ref, j_btnCancel_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr j_btnSubmit_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R.id']/field[@name='j_btnSubmit']"
			[Register ("j_btnSubmit")]
			public static int JBtnSubmit {
				get {
					if (j_btnSubmit_jfieldId == IntPtr.Zero)
						j_btnSubmit_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_btnSubmit", "I");
					return JNIEnv.GetStaticIntField (class_ref, j_btnSubmit_jfieldId);
				}
				set {
					if (j_btnSubmit_jfieldId == IntPtr.Zero)
						j_btnSubmit_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_btnSubmit", "I");
					try {
						JNIEnv.SetStaticField (class_ref, j_btnSubmit_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr j_layout1_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R.id']/field[@name='j_layout1']"
			[Register ("j_layout1")]
			public static int JLayout1 {
				get {
					if (j_layout1_jfieldId == IntPtr.Zero)
						j_layout1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_layout1", "I");
					return JNIEnv.GetStaticIntField (class_ref, j_layout1_jfieldId);
				}
				set {
					if (j_layout1_jfieldId == IntPtr.Zero)
						j_layout1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_layout1", "I");
					try {
						JNIEnv.SetStaticField (class_ref, j_layout1_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr j_layout2_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R.id']/field[@name='j_layout2']"
			[Register ("j_layout2")]
			public static int JLayout2 {
				get {
					if (j_layout2_jfieldId == IntPtr.Zero)
						j_layout2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_layout2", "I");
					return JNIEnv.GetStaticIntField (class_ref, j_layout2_jfieldId);
				}
				set {
					if (j_layout2_jfieldId == IntPtr.Zero)
						j_layout2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_layout2", "I");
					try {
						JNIEnv.SetStaticField (class_ref, j_layout2_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr j_layout3_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R.id']/field[@name='j_layout3']"
			[Register ("j_layout3")]
			public static int JLayout3 {
				get {
					if (j_layout3_jfieldId == IntPtr.Zero)
						j_layout3_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_layout3", "I");
					return JNIEnv.GetStaticIntField (class_ref, j_layout3_jfieldId);
				}
				set {
					if (j_layout3_jfieldId == IntPtr.Zero)
						j_layout3_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_layout3", "I");
					try {
						JNIEnv.SetStaticField (class_ref, j_layout3_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr j_options1_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R.id']/field[@name='j_options1']"
			[Register ("j_options1")]
			public static int JOptions1 {
				get {
					if (j_options1_jfieldId == IntPtr.Zero)
						j_options1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_options1", "I");
					return JNIEnv.GetStaticIntField (class_ref, j_options1_jfieldId);
				}
				set {
					if (j_options1_jfieldId == IntPtr.Zero)
						j_options1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_options1", "I");
					try {
						JNIEnv.SetStaticField (class_ref, j_options1_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr j_options2_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R.id']/field[@name='j_options2']"
			[Register ("j_options2")]
			public static int JOptions2 {
				get {
					if (j_options2_jfieldId == IntPtr.Zero)
						j_options2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_options2", "I");
					return JNIEnv.GetStaticIntField (class_ref, j_options2_jfieldId);
				}
				set {
					if (j_options2_jfieldId == IntPtr.Zero)
						j_options2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_options2", "I");
					try {
						JNIEnv.SetStaticField (class_ref, j_options2_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr j_options3_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R.id']/field[@name='j_options3']"
			[Register ("j_options3")]
			public static int JOptions3 {
				get {
					if (j_options3_jfieldId == IntPtr.Zero)
						j_options3_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_options3", "I");
					return JNIEnv.GetStaticIntField (class_ref, j_options3_jfieldId);
				}
				set {
					if (j_options3_jfieldId == IntPtr.Zero)
						j_options3_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_options3", "I");
					try {
						JNIEnv.SetStaticField (class_ref, j_options3_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr j_optionspicker_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R.id']/field[@name='j_optionspicker']"
			[Register ("j_optionspicker")]
			public static int JOptionspicker {
				get {
					if (j_optionspicker_jfieldId == IntPtr.Zero)
						j_optionspicker_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_optionspicker", "I");
					return JNIEnv.GetStaticIntField (class_ref, j_optionspicker_jfieldId);
				}
				set {
					if (j_optionspicker_jfieldId == IntPtr.Zero)
						j_optionspicker_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_optionspicker", "I");
					try {
						JNIEnv.SetStaticField (class_ref, j_optionspicker_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("cn/jeesoft/widget/pickerview/R$id", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Id); }
			}

			internal Id (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R.id']/constructor[@name='R.id' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Id ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Id)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R.layout']"
		[global::Android.Runtime.Register ("cn/jeesoft/widget/pickerview/R$layout", DoNotGenerateAcw=true)]
		public sealed partial class Layout : global::Java.Lang.Object {


			static IntPtr j_picker_dialog_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R.layout']/field[@name='j_picker_dialog']"
			[Register ("j_picker_dialog")]
			public static int JPickerDialog {
				get {
					if (j_picker_dialog_jfieldId == IntPtr.Zero)
						j_picker_dialog_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_picker_dialog", "I");
					return JNIEnv.GetStaticIntField (class_ref, j_picker_dialog_jfieldId);
				}
				set {
					if (j_picker_dialog_jfieldId == IntPtr.Zero)
						j_picker_dialog_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_picker_dialog", "I");
					try {
						JNIEnv.SetStaticField (class_ref, j_picker_dialog_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr j_picker_items_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R.layout']/field[@name='j_picker_items']"
			[Register ("j_picker_items")]
			public static int JPickerItems {
				get {
					if (j_picker_items_jfieldId == IntPtr.Zero)
						j_picker_items_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_picker_items", "I");
					return JNIEnv.GetStaticIntField (class_ref, j_picker_items_jfieldId);
				}
				set {
					if (j_picker_items_jfieldId == IntPtr.Zero)
						j_picker_items_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_picker_items", "I");
					try {
						JNIEnv.SetStaticField (class_ref, j_picker_items_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("cn/jeesoft/widget/pickerview/R$layout", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Layout); }
			}

			internal Layout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R.layout']/constructor[@name='R.layout' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Layout ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Layout)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R.string']"
		[global::Android.Runtime.Register ("cn/jeesoft/widget/pickerview/R$string", DoNotGenerateAcw=true)]
		public sealed partial class String : global::Java.Lang.Object {


			static IntPtr j_pickerview_cancel_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R.string']/field[@name='j_pickerview_cancel']"
			[Register ("j_pickerview_cancel")]
			public static int JPickerviewCancel {
				get {
					if (j_pickerview_cancel_jfieldId == IntPtr.Zero)
						j_pickerview_cancel_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_pickerview_cancel", "I");
					return JNIEnv.GetStaticIntField (class_ref, j_pickerview_cancel_jfieldId);
				}
				set {
					if (j_pickerview_cancel_jfieldId == IntPtr.Zero)
						j_pickerview_cancel_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_pickerview_cancel", "I");
					try {
						JNIEnv.SetStaticField (class_ref, j_pickerview_cancel_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr j_pickerview_submit_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R.string']/field[@name='j_pickerview_submit']"
			[Register ("j_pickerview_submit")]
			public static int JPickerviewSubmit {
				get {
					if (j_pickerview_submit_jfieldId == IntPtr.Zero)
						j_pickerview_submit_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_pickerview_submit", "I");
					return JNIEnv.GetStaticIntField (class_ref, j_pickerview_submit_jfieldId);
				}
				set {
					if (j_pickerview_submit_jfieldId == IntPtr.Zero)
						j_pickerview_submit_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_pickerview_submit", "I");
					try {
						JNIEnv.SetStaticField (class_ref, j_pickerview_submit_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("cn/jeesoft/widget/pickerview/R$string", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (String); }
			}

			internal String (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R.string']/constructor[@name='R.string' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe String ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (String)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R.style']"
		[global::Android.Runtime.Register ("cn/jeesoft/widget/pickerview/R$style", DoNotGenerateAcw=true)]
		public sealed partial class Style : global::Java.Lang.Object {


			static IntPtr j_timepopwindow_anim_style_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R.style']/field[@name='j_timepopwindow_anim_style']"
			[Register ("j_timepopwindow_anim_style")]
			public static int JTimepopwindowAnimStyle {
				get {
					if (j_timepopwindow_anim_style_jfieldId == IntPtr.Zero)
						j_timepopwindow_anim_style_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_timepopwindow_anim_style", "I");
					return JNIEnv.GetStaticIntField (class_ref, j_timepopwindow_anim_style_jfieldId);
				}
				set {
					if (j_timepopwindow_anim_style_jfieldId == IntPtr.Zero)
						j_timepopwindow_anim_style_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j_timepopwindow_anim_style", "I");
					try {
						JNIEnv.SetStaticField (class_ref, j_timepopwindow_anim_style_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("cn/jeesoft/widget/pickerview/R$style", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Style); }
			}

			internal Style (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R.style']/constructor[@name='R.style' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Style ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Style)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/jeesoft/widget/pickerview/R", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (R); }
		}

		internal R (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='R']/constructor[@name='R' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe R ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (R)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

	}
}
