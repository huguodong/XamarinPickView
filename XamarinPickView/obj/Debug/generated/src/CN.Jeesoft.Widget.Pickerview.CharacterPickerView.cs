using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jeesoft.Widget.Pickerview {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='CharacterPickerView']"
	[global::Android.Runtime.Register ("cn/jeesoft/widget/pickerview/CharacterPickerView", DoNotGenerateAcw=true)]
	public partial class CharacterPickerView : global::Android.Widget.FrameLayout {

		// Metadata.xml XPath interface reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/interface[@name='CharacterPickerView.OnOptionChangedListener']"
		[Register ("cn/jeesoft/widget/pickerview/CharacterPickerView$OnOptionChangedListener", "", "CN.Jeesoft.Widget.Pickerview.CharacterPickerView/IOnOptionChangedListenerInvoker")]
		public partial interface IOnOptionChangedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/interface[@name='CharacterPickerView.OnOptionChangedListener']/method[@name='onOptionChanged' and count(parameter)=4 and parameter[1][@type='cn.jeesoft.widget.pickerview.CharacterPickerView'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("onOptionChanged", "(Lcn/jeesoft/widget/pickerview/CharacterPickerView;III)V", "GetOnOptionChanged_Lcn_jeesoft_widget_pickerview_CharacterPickerView_IIIHandler:CN.Jeesoft.Widget.Pickerview.CharacterPickerView/IOnOptionChangedListenerInvoker, XamarinPickView")]
			void OnOptionChanged (global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView p0, int p1, int p2, int p3);

		}

		[global::Android.Runtime.Register ("cn/jeesoft/widget/pickerview/CharacterPickerView$OnOptionChangedListener", DoNotGenerateAcw=true)]
		internal class IOnOptionChangedListenerInvoker : global::Java.Lang.Object, IOnOptionChangedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("cn/jeesoft/widget/pickerview/CharacterPickerView$OnOptionChangedListener");
			IntPtr class_ref;

			public static IOnOptionChangedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnOptionChangedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "cn.jeesoft.widget.pickerview.CharacterPickerView.OnOptionChangedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnOptionChangedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnOptionChangedListenerInvoker); }
			}

			static Delegate cb_onOptionChanged_Lcn_jeesoft_widget_pickerview_CharacterPickerView_III;
#pragma warning disable 0169
			static Delegate GetOnOptionChanged_Lcn_jeesoft_widget_pickerview_CharacterPickerView_IIIHandler ()
			{
				if (cb_onOptionChanged_Lcn_jeesoft_widget_pickerview_CharacterPickerView_III == null)
					cb_onOptionChanged_Lcn_jeesoft_widget_pickerview_CharacterPickerView_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int>) n_OnOptionChanged_Lcn_jeesoft_widget_pickerview_CharacterPickerView_III);
				return cb_onOptionChanged_Lcn_jeesoft_widget_pickerview_CharacterPickerView_III;
			}

			static void n_OnOptionChanged_Lcn_jeesoft_widget_pickerview_CharacterPickerView_III (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3)
			{
				global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView.IOnOptionChangedListener __this = global::Java.Lang.Object.GetObject<global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView.IOnOptionChangedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView p0 = global::Java.Lang.Object.GetObject<global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnOptionChanged (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			IntPtr id_onOptionChanged_Lcn_jeesoft_widget_pickerview_CharacterPickerView_III;
			public unsafe void OnOptionChanged (global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView p0, int p1, int p2, int p3)
			{
				if (id_onOptionChanged_Lcn_jeesoft_widget_pickerview_CharacterPickerView_III == IntPtr.Zero)
					id_onOptionChanged_Lcn_jeesoft_widget_pickerview_CharacterPickerView_III = JNIEnv.GetMethodID (class_ref, "onOptionChanged", "(Lcn/jeesoft/widget/pickerview/CharacterPickerView;III)V");
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (Handle, id_onOptionChanged_Lcn_jeesoft_widget_pickerview_CharacterPickerView_III, __args);
			}

		}

		public partial class OptionChangedEventArgs : global::System.EventArgs {

			public OptionChangedEventArgs (global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView p0, int p1, int p2, int p3)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
			}

			global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView p0;
			public global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView P0 {
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

			int p3;
			public int P3 {
				get { return p3; }
			}
		}

		[global::Android.Runtime.Register ("mono/cn/jeesoft/widget/pickerview/CharacterPickerView_OnOptionChangedListenerImplementor")]
		internal sealed partial class IOnOptionChangedListenerImplementor : global::Java.Lang.Object, IOnOptionChangedListener {

			object sender;

			public IOnOptionChangedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/cn/jeesoft/widget/pickerview/CharacterPickerView_OnOptionChangedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<OptionChangedEventArgs> Handler;
#pragma warning restore 0649

			public void OnOptionChanged (global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView p0, int p1, int p2, int p3)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new OptionChangedEventArgs (p0, p1, p2, p3));
			}

			internal static bool __IsEmpty (IOnOptionChangedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/jeesoft/widget/pickerview/CharacterPickerView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CharacterPickerView); }
		}

		protected CharacterPickerView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='CharacterPickerView']/constructor[@name='CharacterPickerView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe CharacterPickerView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (CharacterPickerView)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='CharacterPickerView']/constructor[@name='CharacterPickerView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe CharacterPickerView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (CharacterPickerView)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='CharacterPickerView']/constructor[@name='CharacterPickerView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe CharacterPickerView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (CharacterPickerView)) {
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

		static Delegate cb_getCurrentItems;
#pragma warning disable 0169
		static Delegate GetGetCurrentItemsHandler ()
		{
			if (cb_getCurrentItems == null)
				cb_getCurrentItems = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentItems);
			return cb_getCurrentItems;
		}

		static IntPtr n_GetCurrentItems (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView __this = global::Java.Lang.Object.GetObject<global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetCurrentItems ());
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentItems;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='CharacterPickerView']/method[@name='getCurrentItems' and count(parameter)=0]"
		[Register ("getCurrentItems", "()[I", "GetGetCurrentItemsHandler")]
		public virtual unsafe int[] GetCurrentItems ()
		{
			if (id_getCurrentItems == IntPtr.Zero)
				id_getCurrentItems = JNIEnv.GetMethodID (class_ref, "getCurrentItems", "()[I");
			try {

				if (GetType () == ThresholdType)
					return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getCurrentItems), JniHandleOwnership.TransferLocalRef, typeof (int));
				else
					return (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentItems", "()[I")), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_setCurrentItems_III;
#pragma warning disable 0169
		static Delegate GetSetCurrentItems_IIIHandler ()
		{
			if (cb_setCurrentItems_III == null)
				cb_setCurrentItems_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int>) n_SetCurrentItems_III);
			return cb_setCurrentItems_III;
		}

		static void n_SetCurrentItems_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView __this = global::Java.Lang.Object.GetObject<global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCurrentItems (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setCurrentItems_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='CharacterPickerView']/method[@name='setCurrentItems' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("setCurrentItems", "(III)V", "GetSetCurrentItems_IIIHandler")]
		public virtual unsafe void SetCurrentItems (int p0, int p1, int p2)
		{
			if (id_setCurrentItems_III == IntPtr.Zero)
				id_setCurrentItems_III = JNIEnv.GetMethodID (class_ref, "setCurrentItems", "(III)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setCurrentItems_III, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCurrentItems", "(III)V"), __args);
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
			global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView __this = global::Java.Lang.Object.GetObject<global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCyclic (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCyclic_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='CharacterPickerView']/method[@name='setCyclic' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static Delegate cb_setOnOptionChangedListener_Lcn_jeesoft_widget_pickerview_CharacterPickerView_OnOptionChangedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnOptionChangedListener_Lcn_jeesoft_widget_pickerview_CharacterPickerView_OnOptionChangedListener_Handler ()
		{
			if (cb_setOnOptionChangedListener_Lcn_jeesoft_widget_pickerview_CharacterPickerView_OnOptionChangedListener_ == null)
				cb_setOnOptionChangedListener_Lcn_jeesoft_widget_pickerview_CharacterPickerView_OnOptionChangedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnOptionChangedListener_Lcn_jeesoft_widget_pickerview_CharacterPickerView_OnOptionChangedListener_);
			return cb_setOnOptionChangedListener_Lcn_jeesoft_widget_pickerview_CharacterPickerView_OnOptionChangedListener_;
		}

		static void n_SetOnOptionChangedListener_Lcn_jeesoft_widget_pickerview_CharacterPickerView_OnOptionChangedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView __this = global::Java.Lang.Object.GetObject<global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView.IOnOptionChangedListener p0 = (global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView.IOnOptionChangedListener)global::Java.Lang.Object.GetObject<global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView.IOnOptionChangedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnOptionChangedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnOptionChangedListener_Lcn_jeesoft_widget_pickerview_CharacterPickerView_OnOptionChangedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='CharacterPickerView']/method[@name='setOnOptionChangedListener' and count(parameter)=1 and parameter[1][@type='cn.jeesoft.widget.pickerview.CharacterPickerView.OnOptionChangedListener']]"
		[Register ("setOnOptionChangedListener", "(Lcn/jeesoft/widget/pickerview/CharacterPickerView$OnOptionChangedListener;)V", "GetSetOnOptionChangedListener_Lcn_jeesoft_widget_pickerview_CharacterPickerView_OnOptionChangedListener_Handler")]
		public virtual unsafe void SetOnOptionChangedListener (global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView.IOnOptionChangedListener p0)
		{
			if (id_setOnOptionChangedListener_Lcn_jeesoft_widget_pickerview_CharacterPickerView_OnOptionChangedListener_ == IntPtr.Zero)
				id_setOnOptionChangedListener_Lcn_jeesoft_widget_pickerview_CharacterPickerView_OnOptionChangedListener_ = JNIEnv.GetMethodID (class_ref, "setOnOptionChangedListener", "(Lcn/jeesoft/widget/pickerview/CharacterPickerView$OnOptionChangedListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnOptionChangedListener_Lcn_jeesoft_widget_pickerview_CharacterPickerView_OnOptionChangedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnOptionChangedListener", "(Lcn/jeesoft/widget/pickerview/CharacterPickerView$OnOptionChangedListener;)V"), __args);
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
			global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView __this = global::Java.Lang.Object.GetObject<global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPicker (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPicker_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='CharacterPickerView']/method[@name='setPicker' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
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
			global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView __this = global::Java.Lang.Object.GetObject<global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::System.Collections.Generic.IList<string>>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetPicker (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setPicker_Ljava_util_List_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='CharacterPickerView']/method[@name='setPicker' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[2][@type='java.util.List&lt;java.util.List&lt;java.lang.String&gt;&gt;']]"
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
			global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView __this = global::Java.Lang.Object.GetObject<global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::System.Collections.Generic.IList<string>>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetPicker (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setPicker_Ljava_util_List_Ljava_util_List_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='CharacterPickerView']/method[@name='setPicker' and count(parameter)=3 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[2][@type='java.util.List&lt;java.util.List&lt;java.lang.String&gt;&gt;'] and parameter[3][@type='java.util.List&lt;java.util.List&lt;java.util.List&lt;java.lang.String&gt;&gt;&gt;']]"
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
			global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView __this = global::Java.Lang.Object.GetObject<global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSelectOptions (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSelectOptions_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='CharacterPickerView']/method[@name='setSelectOptions' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView __this = global::Java.Lang.Object.GetObject<global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSelectOptions (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setSelectOptions_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='CharacterPickerView']/method[@name='setSelectOptions' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
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
			global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView __this = global::Java.Lang.Object.GetObject<global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSelectOptions (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setSelectOptions_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/class[@name='CharacterPickerView']/method[@name='setSelectOptions' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
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

#region "Event implementation for CN.Jeesoft.Widget.Pickerview.CharacterPickerView.IOnOptionChangedListener"
		public event EventHandler<global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView.OptionChangedEventArgs> OptionChanged {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView.IOnOptionChangedListener, global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView.IOnOptionChangedListenerImplementor>(
						ref weak_implementor_SetOnOptionChangedListener,
						__CreateIOnOptionChangedListenerImplementor,
						SetOnOptionChangedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView.IOnOptionChangedListener, global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView.IOnOptionChangedListenerImplementor>(
						ref weak_implementor_SetOnOptionChangedListener,
						global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView.IOnOptionChangedListenerImplementor.__IsEmpty,
						__v => SetOnOptionChangedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnOptionChangedListener;

		global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView.IOnOptionChangedListenerImplementor __CreateIOnOptionChangedListenerImplementor ()
		{
			return new global::CN.Jeesoft.Widget.Pickerview.CharacterPickerView.IOnOptionChangedListenerImplementor (this);
		}
#endregion
	}
}
