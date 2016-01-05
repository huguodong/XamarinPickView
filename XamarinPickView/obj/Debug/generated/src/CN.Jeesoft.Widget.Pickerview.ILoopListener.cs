using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jeesoft.Widget.Pickerview {

	// Metadata.xml XPath interface reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/interface[@name='LoopListener']"
	[Register ("cn/jeesoft/widget/pickerview/LoopListener", "", "CN.Jeesoft.Widget.Pickerview.ILoopListenerInvoker")]
	public partial interface ILoopListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jeesoft.widget.pickerview']/interface[@name='LoopListener']/method[@name='onItemSelect' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onItemSelect", "(I)V", "GetOnItemSelect_IHandler:CN.Jeesoft.Widget.Pickerview.ILoopListenerInvoker, XamarinPickView")]
		void OnItemSelect (int p0);

	}

	[global::Android.Runtime.Register ("cn/jeesoft/widget/pickerview/LoopListener", DoNotGenerateAcw=true)]
	internal class ILoopListenerInvoker : global::Java.Lang.Object, ILoopListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("cn/jeesoft/widget/pickerview/LoopListener");
		IntPtr class_ref;

		public static ILoopListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILoopListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "cn.jeesoft.widget.pickerview.LoopListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILoopListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ILoopListenerInvoker); }
		}

		static Delegate cb_onItemSelect_I;
#pragma warning disable 0169
		static Delegate GetOnItemSelect_IHandler ()
		{
			if (cb_onItemSelect_I == null)
				cb_onItemSelect_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnItemSelect_I);
			return cb_onItemSelect_I;
		}

		static void n_OnItemSelect_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::CN.Jeesoft.Widget.Pickerview.ILoopListener __this = global::Java.Lang.Object.GetObject<global::CN.Jeesoft.Widget.Pickerview.ILoopListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnItemSelect (p0);
		}
#pragma warning restore 0169

		IntPtr id_onItemSelect_I;
		public unsafe void OnItemSelect (int p0)
		{
			if (id_onItemSelect_I == IntPtr.Zero)
				id_onItemSelect_I = JNIEnv.GetMethodID (class_ref, "onItemSelect", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onItemSelect_I, __args);
		}

	}

	public partial class LoopEventArgs : global::System.EventArgs {

		public LoopEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/cn/jeesoft/widget/pickerview/LoopListenerImplementor")]
	internal sealed partial class ILoopListenerImplementor : global::Java.Lang.Object, ILoopListener {

		object sender;

		public ILoopListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/cn/jeesoft/widget/pickerview/LoopListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<LoopEventArgs> Handler;
#pragma warning restore 0649

		public void OnItemSelect (int p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new LoopEventArgs (p0));
		}

		internal static bool __IsEmpty (ILoopListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
