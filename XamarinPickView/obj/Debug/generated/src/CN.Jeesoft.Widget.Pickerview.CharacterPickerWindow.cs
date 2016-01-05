using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jeesoft.Widget.Pickerview {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='CharacterPickerWindow']"
	[global::Android.Runtime.Register ("cn/jeesoft/widget/pickerview/CharacterPickerWindow", DoNotGenerateAcw=true)]
	public partial class CharacterPickerWindow : global::Android.Widget.PopupWindow, global::Android.Views.View.IOnClickListener {

		// Metadata.xml XPath interface reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/interface[@name='CharacterPickerWindow.OnOptionsSelectListener']"
		[Register ("cn/jeesoft/widget/pickerview/CharacterPickerWindow$OnOptionsSelectListener", "", "CN.Jeesoft.Widget.Pickerview.CharacterPickerWindow/IOnOptionsSelectListenerInvoker")]
		public partial interface IOnOptionsSelectListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/interface[@name='CharacterPickerWindow.OnOptionsSelectListener']/method[@name='onOptionsSelect' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("onOptionsSelect", "(III)V", "GetOnOptionsSelect_IIIHandler:CN.Jeesoft.Widget.Pickerview.CharacterPickerWindow/IOnOptionsSelectListenerInvoker, XamarinPickView")]
			void OnOptionsSelect (int p0, int p1, int p2);

		}

		[global::Android.Runtime.Register ("cn/jeesoft/widget/pickerview/CharacterPickerWindow$OnOptionsSelectListener", DoNotGenerateAcw=true)]
		internal class IOnOptionsSelectListenerInvoker : global::Java.Lang.Object, IOnOptionsSelectListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("cn/jeesoft/widget/pickerview/CharacterPickerWindow$OnOptionsSelectListener");
			IntPtr class_ref;

			public static IOnOptionsSelectListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnOptionsSelectListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "cn.jeesoft.widget.pickerview.CharacterPickerWindow.OnOptionsSelectListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnOptionsSelectListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnOptionsSelectListenerInvoker); }
			}

			static Delegate cb_onOptionsSelect_III;
#pragma warning disable 0169
			static Delegate GetOnOptionsSelect_IIIHandler ()
			{
				if (cb_onOptionsSelect_III == null)
					cb_onOptionsSelect_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int>) n_OnOptionsSelect_III);
				return cb_onOptionsSelect_III;
			}

			static void n_OnOptionsSelect_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
			{
				global::CN.Jeesoft.Widget.Pickerview.CharacterPickerWindow.IOnOptionsSelectListener __this = global::Java.Lang.Object.GetObject<global::CN.Jeesoft.Widget.Pickerview.CharacterPickerWindow.IOnOptionsSelectListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnOptionsSelect (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onOptionsSelect_III;
			public unsafe void OnOptionsSelect (int p0, int p1, int p2)
			{
				if (id_onOptionsSelect_III == IntPtr.Zero)
					id_onOptionsSelect_III = JNIEnv.GetMethodID (class_ref, "onOptionsSelect", "(III)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (Handle, id_onOptionsSelect_III, __args);
			}

		}

		public partial class OptionsSelectEventArgs : global::System.EventArgs {

			public OptionsSelectEventArgs (int p0, int p1, int p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}

			int p1;
			public int P1 {
				get { return p1; }
			}

			int p2;
			public int P2 {
				get { return p2; }
			}
		}

		[global::Android.Runtime.Register ("mono/cn/jeesoft/widget/pickerview/CharacterPickerWindow_OnOptionsSelectListenerImplementor")]
		internal sealed partial class IOnOptionsSelectListenerImplementor : global::Java.Lang.Object, IOnOptionsSelectListener {

			object sender;

			public IOnOptionsSelectListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/cn/jeesoft/widget/pickerview/CharacterPickerWindow_OnOptionsSelectListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<OptionsSelectEventArgs> Handler;
#pragma warning restore 0649

			public void OnOptionsSelect (int p0, int p1, int p2)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new OptionsSelectEventArgs (p0, p1, p2));
			}

			internal static bool __IsEmpty (IOnOptionsSelectListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/jeesoft/widget/pickerview/CharacterPickerWindow", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CharacterPickerWindow); }
		}

		protected CharacterPickerWindow (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='CharacterPickerWindow']/constructor[@name='CharacterPickerWindow' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe CharacterPickerWindow (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (CharacterPickerWindow)) {
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

		static Delegate cb_getPickerView;
#pragma warning disable 0169
		static Delegate GetGetPickerViewHandler ()
		{
			if (cb_getPickerView == null)
				cb_getPickerView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPickerView);
			return cb_getPickerView;
		}

		static IntPtr n_GetPickerView (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jeesoft.Widget.Pickerview.CharacterPickerWindow __this = global::Java.Lang.Object.GetObject<global::CN.Jeesoft.Widget.Pickerview.CharacterPickerWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PickerView);
		}
#pragma warning restore 0169

		static IntPtr id_getPickerView;
		public virtual unsafe global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView PickerView {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='CharacterPickerWindow']/method[@name='getPickerView' and count(parameter)=0]"
			[Register ("getPickerView", "()Lcn/jeesoft/widget/pickerview/CharacterPickerView;", "GetGetPickerViewHandler")]
			get {
				if (id_getPickerView == IntPtr.Zero)
					id_getPickerView = JNIEnv.GetMethodID (class_ref, "getPickerView", "()Lcn/jeesoft/widget/pickerview/CharacterPickerView;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView> (JNIEnv.CallObjectMethod  (Handle, id_getPickerView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPickerView", "()Lcn/jeesoft/widget/pickerview/CharacterPickerView;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_onClick_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnClick_Landroid_view_View_Handler ()
		{
			if (cb_onClick_Landroid_view_View_ == null)
				cb_onClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnClick_Landroid_view_View_);
			return cb_onClick_Landroid_view_View_;
		}

		static void n_OnClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jeesoft.Widget.Pickerview.CharacterPickerWindow __this = global::Java.Lang.Object.GetObject<global::CN.Jeesoft.Widget.Pickerview.CharacterPickerWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnClick (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onClick_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='CharacterPickerWindow']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("onClick", "(Landroid/view/View;)V", "GetOnClick_Landroid_view_View_Handler")]
		public virtual unsafe void OnClick (global::Android.Views.View p0)
		{
			if (id_onClick_Landroid_view_View_ == IntPtr.Zero)
				id_onClick_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onClick", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onClick_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onClick", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setCyclic_Z;
#pragma warning disable 0169
		static Delegate GetSetCyclic_ZHandler ()
		{
			if (cb_setCyclic_Z == null)
				cb_setCyclic_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetCyclic_Z);
			return cb_setCyclic_Z;
		}

		static void n_SetCyclic_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::CN.Jeesoft.Widget.Pickerview.CharacterPickerWindow __this = global::Java.Lang.Object.GetObject<global::CN.Jeesoft.Widget.Pickerview.CharacterPickerWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCyclic (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCyclic_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='CharacterPickerWindow']/method[@name='setCyclic' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setCyclic", "(Z)V", "GetSetCyclic_ZHandler")]
		public virtual unsafe void SetCyclic (bool p0)
		{
			if (id_setCyclic_Z == IntPtr.Zero)
				id_setCyclic_Z = JNIEnv.GetMethodID (class_ref, "setCyclic", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setCyclic_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCyclic", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnoptionsSelectListener_Lcn_jeesoft_widget_pickerview_CharacterPickerWindow_OnOptionsSelectListener_;
#pragma warning disable 0169
		static Delegate GetSetOnoptionsSelectListener_Lcn_jeesoft_widget_pickerview_CharacterPickerWindow_OnOptionsSelectListener_Handler ()
		{
			if (cb_setOnoptionsSelectListener_Lcn_jeesoft_widget_pickerview_CharacterPickerWindow_OnOptionsSelectListener_ == null)
				cb_setOnoptionsSelectListener_Lcn_jeesoft_widget_pickerview_CharacterPickerWindow_OnOptionsSelectListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnoptionsSelectListener_Lcn_jeesoft_widget_pickerview_CharacterPickerWindow_OnOptionsSelectListener_);
			return cb_setOnoptionsSelectListener_Lcn_jeesoft_widget_pickerview_CharacterPickerWindow_OnOptionsSelectListener_;
		}

		static void n_SetOnoptionsSelectListener_Lcn_jeesoft_widget_pickerview_CharacterPickerWindow_OnOptionsSelectListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jeesoft.Widget.Pickerview.CharacterPickerWindow __this = global::Java.Lang.Object.GetObject<global::CN.Jeesoft.Widget.Pickerview.CharacterPickerWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::CN.Jeesoft.Widget.Pickerview.CharacterPickerWindow.IOnOptionsSelectListener p0 = (global::CN.Jeesoft.Widget.Pickerview.CharacterPickerWindow.IOnOptionsSelectListener)global::Java.Lang.Object.GetObject<global::CN.Jeesoft.Widget.Pickerview.CharacterPickerWindow.IOnOptionsSelectListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnoptionsSelectListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnoptionsSelectListener_Lcn_jeesoft_widget_pickerview_CharacterPickerWindow_OnOptionsSelectListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='CharacterPickerWindow']/method[@name='setOnoptionsSelectListener' and count(parameter)=1 and parameter[1][@type='cn.jeesoft.widget.pickerview.CharacterPickerWindow.OnOptionsSelectListener']]"
		[Register ("setOnoptionsSelectListener", "(Lcn/jeesoft/widget/pickerview/CharacterPickerWindow$OnOptionsSelectListener;)V", "GetSetOnoptionsSelectListener_Lcn_jeesoft_widget_pickerview_CharacterPickerWindow_OnOptionsSelectListener_Handler")]
		public virtual unsafe void SetOnoptionsSelectListener (global::CN.Jeesoft.Widget.Pickerview.CharacterPickerWindow.IOnOptionsSelectListener p0)
		{
			if (id_setOnoptionsSelectListener_Lcn_jeesoft_widget_pickerview_CharacterPickerWindow_OnOptionsSelectListener_ == IntPtr.Zero)
				id_setOnoptionsSelectListener_Lcn_jeesoft_widget_pickerview_CharacterPickerWindow_OnOptionsSelectListener_ = JNIEnv.GetMethodID (class_ref, "setOnoptionsSelectListener", "(Lcn/jeesoft/widget/pickerview/CharacterPickerWindow$OnOptionsSelectListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnoptionsSelectListener_Lcn_jeesoft_widget_pickerview_CharacterPickerWindow_OnOptionsSelectListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnoptionsSelectListener", "(Lcn/jeesoft/widget/pickerview/CharacterPickerWindow$OnOptionsSelectListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setPicker_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetPicker_Ljava_util_List_Handler ()
		{
			if (cb_setPicker_Ljava_util_List_ == null)
				cb_setPicker_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPicker_Ljava_util_List_);
			return cb_setPicker_Ljava_util_List_;
		}

		static void n_SetPicker_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jeesoft.Widget.Pickerview.CharacterPickerWindow __this = global::Java.Lang.Object.GetObject<global::CN.Jeesoft.Widget.Pickerview.CharacterPickerWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPicker (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPicker_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='CharacterPickerWindow']/method[@name='setPicker' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("setPicker", "(Ljava/util/List;)V", "GetSetPicker_Ljava_util_List_Handler")]
		public virtual unsafe void SetPicker (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_setPicker_Ljava_util_List_ == IntPtr.Zero)
				id_setPicker_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setPicker", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPicker_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPicker", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setPicker_Ljava_util_List_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetPicker_Ljava_util_List_Ljava_util_List_Handler ()
		{
			if (cb_setPicker_Ljava_util_List_Ljava_util_List_ == null)
				cb_setPicker_Ljava_util_List_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPicker_Ljava_util_List_Ljava_util_List_);
			return cb_setPicker_Ljava_util_List_Ljava_util_List_;
		}

		static void n_SetPicker_Ljava_util_List_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::CN.Jeesoft.Widget.Pickerview.CharacterPickerWindow __this = global::Java.Lang.Object.GetObject<global::CN.Jeesoft.Widget.Pickerview.CharacterPickerWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::System.Collections.Generic.IList<string>>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetPicker (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setPicker_Ljava_util_List_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='CharacterPickerWindow']/method[@name='setPicker' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[2][@type='java.util.List&lt;java.util.List&lt;java.lang.String&gt;&gt;']]"
		[Register ("setPicker", "(Ljava/util/List;Ljava/util/List;)V", "GetSetPicker_Ljava_util_List_Ljava_util_List_Handler")]
		public virtual unsafe void SetPicker (global::System.Collections.Generic.IList<string> p0, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>> p1)
		{
			if (id_setPicker_Ljava_util_List_Ljava_util_List_ == IntPtr.Zero)
				id_setPicker_Ljava_util_List_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setPicker", "(Ljava/util/List;Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPicker_Ljava_util_List_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPicker", "(Ljava/util/List;Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setPicker_Ljava_util_List_Ljava_util_List_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetPicker_Ljava_util_List_Ljava_util_List_Ljava_util_List_Handler ()
		{
			if (cb_setPicker_Ljava_util_List_Ljava_util_List_Ljava_util_List_ == null)
				cb_setPicker_Ljava_util_List_Ljava_util_List_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPicker_Ljava_util_List_Ljava_util_List_Ljava_util_List_);
			return cb_setPicker_Ljava_util_List_Ljava_util_List_Ljava_util_List_;
		}

		static void n_SetPicker_Ljava_util_List_Ljava_util_List_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::CN.Jeesoft.Widget.Pickerview.CharacterPickerWindow __this = global::Java.Lang.Object.GetObject<global::CN.Jeesoft.Widget.Pickerview.CharacterPickerWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::System.Collections.Generic.IList<string>>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetPicker (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setPicker_Ljava_util_List_Ljava_util_List_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='CharacterPickerWindow']/method[@name='setPicker' and count(parameter)=3 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[2][@type='java.util.List&lt;java.util.List&lt;java.lang.String&gt;&gt;'] and parameter[3][@type='java.util.List&lt;java.util.List&lt;java.util.List&lt;java.lang.String&gt;&gt;&gt;']]"
		[Register ("setPicker", "(Ljava/util/List;Ljava/util/List;Ljava/util/List;)V", "GetSetPicker_Ljava_util_List_Ljava_util_List_Ljava_util_List_Handler")]
		public virtual unsafe void SetPicker (global::System.Collections.Generic.IList<string> p0, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>> p1, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>> p2)
		{
			if (id_setPicker_Ljava_util_List_Ljava_util_List_Ljava_util_List_ == IntPtr.Zero)
				id_setPicker_Ljava_util_List_Ljava_util_List_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setPicker", "(Ljava/util/List;Ljava/util/List;Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPicker_Ljava_util_List_Ljava_util_List_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPicker", "(Ljava/util/List;Ljava/util/List;Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_setSelectOptions_I;
#pragma warning disable 0169
		static Delegate GetSetSelectOptions_IHandler ()
		{
			if (cb_setSelectOptions_I == null)
				cb_setSelectOptions_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSelectOptions_I);
			return cb_setSelectOptions_I;
		}

		static void n_SetSelectOptions_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::CN.Jeesoft.Widget.Pickerview.CharacterPickerWindow __this = global::Java.Lang.Object.GetObject<global::CN.Jeesoft.Widget.Pickerview.CharacterPickerWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSelectOptions (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSelectOptions_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='CharacterPickerWindow']/method[@name='setSelectOptions' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSelectOptions", "(I)V", "GetSetSelectOptions_IHandler")]
		public virtual unsafe void SetSelectOptions (int p0)
		{
			if (id_setSelectOptions_I == IntPtr.Zero)
				id_setSelectOptions_I = JNIEnv.GetMethodID (class_ref, "setSelectOptions", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSelectOptions_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelectOptions", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSelectOptions_II;
#pragma warning disable 0169
		static Delegate GetSetSelectOptions_IIHandler ()
		{
			if (cb_setSelectOptions_II == null)
				cb_setSelectOptions_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetSelectOptions_II);
			return cb_setSelectOptions_II;
		}

		static void n_SetSelectOptions_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::CN.Jeesoft.Widget.Pickerview.CharacterPickerWindow __this = global::Java.Lang.Object.GetObject<global::CN.Jeesoft.Widget.Pickerview.CharacterPickerWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSelectOptions (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setSelectOptions_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='CharacterPickerWindow']/method[@name='setSelectOptions' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setSelectOptions", "(II)V", "GetSetSelectOptions_IIHandler")]
		public virtual unsafe void SetSelectOptions (int p0, int p1)
		{
			if (id_setSelectOptions_II == IntPtr.Zero)
				id_setSelectOptions_II = JNIEnv.GetMethodID (class_ref, "setSelectOptions", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSelectOptions_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelectOptions", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSelectOptions_III;
#pragma warning disable 0169
		static Delegate GetSetSelectOptions_IIIHandler ()
		{
			if (cb_setSelectOptions_III == null)
				cb_setSelectOptions_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int>) n_SetSelectOptions_III);
			return cb_setSelectOptions_III;
		}

		static void n_SetSelectOptions_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			global::CN.Jeesoft.Widget.Pickerview.CharacterPickerWindow __this = global::Java.Lang.Object.GetObject<global::CN.Jeesoft.Widget.Pickerview.CharacterPickerWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSelectOptions (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setSelectOptions_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='CharacterPickerWindow']/method[@name='setSelectOptions' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("setSelectOptions", "(III)V", "GetSetSelectOptions_IIIHandler")]
		public virtual unsafe void SetSelectOptions (int p0, int p1, int p2)
		{
			if (id_setSelectOptions_III == IntPtr.Zero)
				id_setSelectOptions_III = JNIEnv.GetMethodID (class_ref, "setSelectOptions", "(III)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSelectOptions_III, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelectOptions", "(III)V"), __args);
			} finally {
			}
		}

#region "Event implementation for CN.Jeesoft.Widget.Pickerview.CharacterPickerWindow.IOnOptionsSelectListener"
		public event EventHandler<global::CN.Jeesoft.Widget.Pickerview.CharacterPickerWindow.OptionsSelectEventArgs> optionsSelect {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::CN.Jeesoft.Widget.Pickerview.CharacterPickerWindow.IOnOptionsSelectListener, global::CN.Jeesoft.Widget.Pickerview.CharacterPickerWindow.IOnOptionsSelectListenerImplementor>(
						ref weak_implementor_SetOnoptionsSelectListener,
						__CreateIOnOptionsSelectListenerImplementor,
						SetOnoptionsSelectListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::CN.Jeesoft.Widget.Pickerview.CharacterPickerWindow.IOnOptionsSelectListener, global::CN.Jeesoft.Widget.Pickerview.CharacterPickerWindow.IOnOptionsSelectListenerImplementor>(
						ref weak_implementor_SetOnoptionsSelectListener,
						global::CN.Jeesoft.Widget.Pickerview.CharacterPickerWindow.IOnOptionsSelectListenerImplementor.__IsEmpty,
						__v => SetOnoptionsSelectListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnoptionsSelectListener;

		global::CN.Jeesoft.Widget.Pickerview.CharacterPickerWindow.IOnOptionsSelectListenerImplementor __CreateIOnOptionsSelectListenerImplementor ()
		{
			return new global::CN.Jeesoft.Widget.Pickerview.CharacterPickerWindow.IOnOptionsSelectListenerImplementor (this);
		}
#endregion
	}
}
