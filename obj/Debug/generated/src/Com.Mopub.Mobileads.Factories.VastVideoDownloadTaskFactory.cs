using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads.Factories {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='VastVideoDownloadTaskFactory']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/factories/VastVideoDownloadTaskFactory", DoNotGenerateAcw=true)]
	public partial class VastVideoDownloadTaskFactory : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/factories/VastVideoDownloadTaskFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VastVideoDownloadTaskFactory); }
		}

		protected VastVideoDownloadTaskFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='VastVideoDownloadTaskFactory']/constructor[@name='VastVideoDownloadTaskFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VastVideoDownloadTaskFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (VastVideoDownloadTaskFactory)) {
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

		static IntPtr id_create_Lcom_mopub_mobileads_VastVideoDownloadTask_VastVideoDownloadTaskListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='VastVideoDownloadTaskFactory']/method[@name='create' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.VastVideoDownloadTask.VastVideoDownloadTaskListener']]"
		[Register ("create", "(Lcom/mopub/mobileads/VastVideoDownloadTask$VastVideoDownloadTaskListener;)Lcom/mopub/mobileads/VastVideoDownloadTask;", "")]
		public static unsafe global::Com.Mopub.Mobileads.VastVideoDownloadTask Create (global::Com.Mopub.Mobileads.VastVideoDownloadTask.IVastVideoDownloadTaskListener p0)
		{
			if (id_create_Lcom_mopub_mobileads_VastVideoDownloadTask_VastVideoDownloadTaskListener_ == IntPtr.Zero)
				id_create_Lcom_mopub_mobileads_VastVideoDownloadTask_VastVideoDownloadTaskListener_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Lcom/mopub/mobileads/VastVideoDownloadTask$VastVideoDownloadTaskListener;)Lcom/mopub/mobileads/VastVideoDownloadTask;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Mopub.Mobileads.VastVideoDownloadTask __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoDownloadTask> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Lcom_mopub_mobileads_VastVideoDownloadTask_VastVideoDownloadTaskListener_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_internalCreate_Lcom_mopub_mobileads_VastVideoDownloadTask_VastVideoDownloadTaskListener_;
#pragma warning disable 0169
		static Delegate GetInternalCreate_Lcom_mopub_mobileads_VastVideoDownloadTask_VastVideoDownloadTaskListener_Handler ()
		{
			if (cb_internalCreate_Lcom_mopub_mobileads_VastVideoDownloadTask_VastVideoDownloadTaskListener_ == null)
				cb_internalCreate_Lcom_mopub_mobileads_VastVideoDownloadTask_VastVideoDownloadTaskListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InternalCreate_Lcom_mopub_mobileads_VastVideoDownloadTask_VastVideoDownloadTaskListener_);
			return cb_internalCreate_Lcom_mopub_mobileads_VastVideoDownloadTask_VastVideoDownloadTaskListener_;
		}

		static IntPtr n_InternalCreate_Lcom_mopub_mobileads_VastVideoDownloadTask_VastVideoDownloadTaskListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.Factories.VastVideoDownloadTaskFactory __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Factories.VastVideoDownloadTaskFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.VastVideoDownloadTask.IVastVideoDownloadTaskListener p0 = (global::Com.Mopub.Mobileads.VastVideoDownloadTask.IVastVideoDownloadTaskListener)global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoDownloadTask.IVastVideoDownloadTaskListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InternalCreate (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_internalCreate_Lcom_mopub_mobileads_VastVideoDownloadTask_VastVideoDownloadTaskListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='VastVideoDownloadTaskFactory']/method[@name='internalCreate' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.VastVideoDownloadTask.VastVideoDownloadTaskListener']]"
		[Register ("internalCreate", "(Lcom/mopub/mobileads/VastVideoDownloadTask$VastVideoDownloadTaskListener;)Lcom/mopub/mobileads/VastVideoDownloadTask;", "GetInternalCreate_Lcom_mopub_mobileads_VastVideoDownloadTask_VastVideoDownloadTaskListener_Handler")]
		protected virtual unsafe global::Com.Mopub.Mobileads.VastVideoDownloadTask InternalCreate (global::Com.Mopub.Mobileads.VastVideoDownloadTask.IVastVideoDownloadTaskListener p0)
		{
			if (id_internalCreate_Lcom_mopub_mobileads_VastVideoDownloadTask_VastVideoDownloadTaskListener_ == IntPtr.Zero)
				id_internalCreate_Lcom_mopub_mobileads_VastVideoDownloadTask_VastVideoDownloadTaskListener_ = JNIEnv.GetMethodID (class_ref, "internalCreate", "(Lcom/mopub/mobileads/VastVideoDownloadTask$VastVideoDownloadTaskListener;)Lcom/mopub/mobileads/VastVideoDownloadTask;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mopub.Mobileads.VastVideoDownloadTask __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoDownloadTask> (JNIEnv.CallObjectMethod  (Handle, id_internalCreate_Lcom_mopub_mobileads_VastVideoDownloadTask_VastVideoDownloadTaskListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.VastVideoDownloadTask> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "internalCreate", "(Lcom/mopub/mobileads/VastVideoDownloadTask$VastVideoDownloadTaskListener;)Lcom/mopub/mobileads/VastVideoDownloadTask;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setInstance_Lcom_mopub_mobileads_factories_VastVideoDownloadTaskFactory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='VastVideoDownloadTaskFactory']/method[@name='setInstance' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.factories.VastVideoDownloadTaskFactory']]"
		[Obsolete (@"deprecated")]
		[Register ("setInstance", "(Lcom/mopub/mobileads/factories/VastVideoDownloadTaskFactory;)V", "")]
		public static unsafe void SetInstance (global::Com.Mopub.Mobileads.Factories.VastVideoDownloadTaskFactory p0)
		{
			if (id_setInstance_Lcom_mopub_mobileads_factories_VastVideoDownloadTaskFactory_ == IntPtr.Zero)
				id_setInstance_Lcom_mopub_mobileads_factories_VastVideoDownloadTaskFactory_ = JNIEnv.GetStaticMethodID (class_ref, "setInstance", "(Lcom/mopub/mobileads/factories/VastVideoDownloadTaskFactory;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setInstance_Lcom_mopub_mobileads_factories_VastVideoDownloadTaskFactory_, __args);
			} finally {
			}
		}

	}
}