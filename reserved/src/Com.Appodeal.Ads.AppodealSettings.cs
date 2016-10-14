using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Appodeal.Ads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.appodeal.ads']/class[@name='AppodealSettings']"
	[global::Android.Runtime.Register ("com/appodeal/ads/AppodealSettings", DoNotGenerateAcw=true)]
	public partial class AppodealSettings : global::Java.Lang.Object {


		static IntPtr b_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='AppodealSettings']/field[@name='b']"
		[Register ("b")]
		public static bool B {
			get {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, b_jfieldId);
			}
			set {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "b", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, b_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr c_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='AppodealSettings']/field[@name='c']"
		[Register ("c")]
		public static global::Com.Appodeal.Ads.Utils.Log.LogLevel C {
			get {
				if (c_jfieldId == IntPtr.Zero)
					c_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "c", "Lcom/appodeal/ads/utils/Log$LogLevel;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, c_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Appodeal.Ads.Utils.Log.LogLevel> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (c_jfieldId == IntPtr.Zero)
					c_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "c", "Lcom/appodeal/ads/utils/Log$LogLevel;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, c_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr d_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='AppodealSettings']/field[@name='d']"
		[Register ("d")]
		public static bool D {
			get {
				if (d_jfieldId == IntPtr.Zero)
					d_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "d", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, d_jfieldId);
			}
			set {
				if (d_jfieldId == IntPtr.Zero)
					d_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "d", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, d_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr e_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='AppodealSettings']/field[@name='e']"
		[Register ("e")]
		public static bool E {
			get {
				if (e_jfieldId == IntPtr.Zero)
					e_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "e", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, e_jfieldId);
			}
			set {
				if (e_jfieldId == IntPtr.Zero)
					e_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "e", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, e_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr f_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='AppodealSettings']/field[@name='f']"
		[Register ("f")]
		public static int F {
			get {
				if (f_jfieldId == IntPtr.Zero)
					f_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "f", "I");
				return JNIEnv.GetStaticIntField (class_ref, f_jfieldId);
			}
			set {
				if (f_jfieldId == IntPtr.Zero)
					f_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "f", "I");
				try {
					JNIEnv.SetStaticField (class_ref, f_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr g_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='AppodealSettings']/field[@name='g']"
		[Register ("g")]
		public static bool G {
			get {
				if (g_jfieldId == IntPtr.Zero)
					g_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "g", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, g_jfieldId);
			}
			set {
				if (g_jfieldId == IntPtr.Zero)
					g_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "g", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, g_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr h_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='AppodealSettings']/field[@name='h']"
		[Register ("h")]
		public static bool H {
			get {
				if (h_jfieldId == IntPtr.Zero)
					h_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "h", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, h_jfieldId);
			}
			set {
				if (h_jfieldId == IntPtr.Zero)
					h_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "h", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, h_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr i_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='AppodealSettings']/field[@name='i']"
		[Register ("i")]
		public static bool I {
			get {
				if (i_jfieldId == IntPtr.Zero)
					i_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "i", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, i_jfieldId);
			}
			set {
				if (i_jfieldId == IntPtr.Zero)
					i_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "i", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, i_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr j_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='AppodealSettings']/field[@name='j']"
		[Register ("j")]
		public static bool J {
			get {
				if (j_jfieldId == IntPtr.Zero)
					j_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, j_jfieldId);
			}
			set {
				if (j_jfieldId == IntPtr.Zero)
					j_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "j", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, j_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr k_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='AppodealSettings']/field[@name='k']"
		[Register ("k")]
		public static bool K {
			get {
				if (k_jfieldId == IntPtr.Zero)
					k_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "k", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, k_jfieldId);
			}
			set {
				if (k_jfieldId == IntPtr.Zero)
					k_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "k", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, k_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr l_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='AppodealSettings']/field[@name='l']"
		[Register ("l")]
		public static bool L {
			get {
				if (l_jfieldId == IntPtr.Zero)
					l_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "l", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, l_jfieldId);
			}
			set {
				if (l_jfieldId == IntPtr.Zero)
					l_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "l", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, l_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr m_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='AppodealSettings']/field[@name='m']"
		[Register ("m")]
		public static bool M {
			get {
				if (m_jfieldId == IntPtr.Zero)
					m_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "m", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, m_jfieldId);
			}
			set {
				if (m_jfieldId == IntPtr.Zero)
					m_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "m", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, m_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr n_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.appodeal.ads']/class[@name='AppodealSettings']/field[@name='n']"
		[Register ("n")]
		public static bool N {
			get {
				if (n_jfieldId == IntPtr.Zero)
					n_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "n", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, n_jfieldId);
			}
			set {
				if (n_jfieldId == IntPtr.Zero)
					n_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "n", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, n_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/appodeal/ads/AppodealSettings", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AppodealSettings); }
		}

		protected AppodealSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.appodeal.ads']/class[@name='AppodealSettings']/constructor[@name='AppodealSettings' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AppodealSettings ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AppodealSettings)) {
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

		static IntPtr id_a_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='AppodealSettings']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("a", "(Ljava/lang/Integer;)I", "")]
		public static unsafe int A (global::Java.Lang.Integer p0)
		{
			if (id_a_Ljava_lang_Integer_ == IntPtr.Zero)
				id_a_Ljava_lang_Integer_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/Integer;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_a_Ljava_lang_Integer_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_disableWebViewCacheClear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='AppodealSettings']/method[@name='disableWebViewCacheClear' and count(parameter)=0]"
		[Register ("disableWebViewCacheClear", "()V", "")]
		public static unsafe void DisableWebViewCacheClear ()
		{
			if (id_disableWebViewCacheClear == IntPtr.Zero)
				id_disableWebViewCacheClear = JNIEnv.GetStaticMethodID (class_ref, "disableWebViewCacheClear", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_disableWebViewCacheClear);
			} finally {
			}
		}

		static IntPtr id_muteVideosIfCallsMuted_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.appodeal.ads']/class[@name='AppodealSettings']/method[@name='muteVideosIfCallsMuted' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("muteVideosIfCallsMuted", "(Z)V", "")]
		public static unsafe void MuteVideosIfCallsMuted (bool p0)
		{
			if (id_muteVideosIfCallsMuted_Z == IntPtr.Zero)
				id_muteVideosIfCallsMuted_Z = JNIEnv.GetStaticMethodID (class_ref, "muteVideosIfCallsMuted", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_muteVideosIfCallsMuted_Z, __args);
			} finally {
			}
		}

	}
}
