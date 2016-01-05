using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jeesoft.Widget.Pickerview {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='LoopView']"
	[global::Android.Runtime.Register ("cn/jeesoft/widget/pickerview/LoopView", DoNotGenerateAcw=true)]
	public partial class LoopView : global::Android.Views.View {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/jeesoft/widget/pickerview/LoopView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LoopView); }
		}

		protected LoopView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='LoopView']/constructor[@name='LoopView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe LoopView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (LoopView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='LoopView']/constructor[@name='LoopView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe LoopView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (LoopView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='LoopView']/constructor[@name='LoopView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe LoopView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (LoopView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_getCurrentItem;
		static IntPtr id_setCurrentItem_I;
		public unsafe int CurrentItem {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='LoopView']/method[@name='getCurrentItem' and count(parameter)=0]"
			[Register ("getCurrentItem", "()I", "GetGetCurrentItemHandler")]
			get {
				if (id_getCurrentItem == IntPtr.Zero)
					id_getCurrentItem = JNIEnv.GetMethodID (class_ref, "getCurrentItem", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getCurrentItem);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='LoopView']/method[@name='setCurrentItem' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCurrentItem", "(I)V", "GetSetCurrentItem_IHandler")]
			set {
				if (id_setCurrentItem_I == IntPtr.Zero)
					id_setCurrentItem_I = JNIEnv.GetMethodID (class_ref, "setCurrentItem", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setCurrentItem_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_b_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='LoopView']/method[@name='b' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("b", "(F)V", "")]
		protected unsafe void B (float p0)
		{
			if (id_b_F == IntPtr.Zero)
				id_b_F = JNIEnv.GetMethodID (class_ref, "b", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_b_F, __args);
			} finally {
			}
		}

		static IntPtr id_b_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='LoopView']/method[@name='b' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("b", "(I)V", "")]
		protected unsafe void B (int p0)
		{
			if (id_b_I == IntPtr.Zero)
				id_b_I = JNIEnv.GetMethodID (class_ref, "b", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_b_I, __args);
			} finally {
			}
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='LoopView']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()V", "")]
		protected unsafe void C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_c);
			} finally {
			}
		}

		static IntPtr id_setArrayList_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='LoopView']/method[@name='setArrayList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;?&gt;']]"
		[Register ("setArrayList", "(Ljava/util/List;)V", "")]
		public unsafe void SetArrayList (global::System.Collections.Generic.IList<object> p0)
		{
			if (id_setArrayList_Ljava_util_List_ == IntPtr.Zero)
				id_setArrayList_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setArrayList", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod  (Handle, id_setArrayList_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setCyclic_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='LoopView']/method[@name='setCyclic' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setCyclic", "(Z)V", "")]
		public unsafe void SetCyclic (bool p0)
		{
			if (id_setCyclic_Z == IntPtr.Zero)
				id_setCyclic_Z = JNIEnv.GetMethodID (class_ref, "setCyclic", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setCyclic_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setListener_Lcn_jeesoft_widget_pickerview_LoopListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='LoopView']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='cn.jeesoft.widget.pickerview.LoopListener']]"
		[Register ("setListener", "(Lcn/jeesoft/widget/pickerview/LoopListener;)V", "")]
		public unsafe void SetListener (global::CN.Jeesoft.Widget.Pickerview.ILoopListener p0)
		{
			if (id_setListener_Lcn_jeesoft_widget_pickerview_LoopListener_ == IntPtr.Zero)
				id_setListener_Lcn_jeesoft_widget_pickerview_LoopListener_ = JNIEnv.GetMethodID (class_ref, "setListener", "(Lcn/jeesoft/widget/pickerview/LoopListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setListener_Lcn_jeesoft_widget_pickerview_LoopListener_, __args);
			} finally {
			}
		}

		static IntPtr id_setNotLoop;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='LoopView']/method[@name='setNotLoop' and count(parameter)=0]"
		[Register ("setNotLoop", "()V", "")]
		public unsafe void SetNotLoop ()
		{
			if (id_setNotLoop == IntPtr.Zero)
				id_setNotLoop = JNIEnv.GetMethodID (class_ref, "setNotLoop", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_setNotLoop);
			} finally {
			}
		}

		static IntPtr id_setTextSize_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='LoopView']/method[@name='setTextSize' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setTextSize", "(F)V", "")]
		public unsafe void SetTextSize (float p0)
		{
			if (id_setTextSize_F == IntPtr.Zero)
				id_setTextSize_F = JNIEnv.GetMethodID (class_ref, "setTextSize", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setTextSize_F, __args);
			} finally {
			}
		}

#region "Event implementation for CN.Jeesoft.Widget.Pickerview.ILoopListener"

		global::CN.Jeesoft.Widget.Pickerview.ILoopListenerImplementor __CreateILoopListenerImplementor ()
		{
			return new global::CN.Jeesoft.Widget.Pickerview.ILoopListenerImplementor (this);
		}
#endregion
	}
}
