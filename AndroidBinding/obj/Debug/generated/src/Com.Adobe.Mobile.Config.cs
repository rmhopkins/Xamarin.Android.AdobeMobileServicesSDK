using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Adobe.Mobile {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Config']"
	[global::Android.Runtime.Register ("com/adobe/mobile/Config", DoNotGenerateAcw=true)]
	public sealed partial class Config : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/adobe/mobile/Config", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Config); }
		}

		internal Config (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Config']/constructor[@name='Config' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Config () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Config)) {
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
		}

		static IntPtr id_getDebugLogging;
		static IntPtr id_setDebugLogging_Ljava_lang_Boolean_;
		public static global::Java.Lang.Boolean DebugLogging {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Config']/method[@name='getDebugLogging' and count(parameter)=0]"
			[Register ("getDebugLogging", "()Ljava/lang/Boolean;", "GetGetDebugLoggingHandler")]
			get {
				if (id_getDebugLogging == IntPtr.Zero)
					id_getDebugLogging = JNIEnv.GetStaticMethodID (class_ref, "getDebugLogging", "()Ljava/lang/Boolean;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDebugLogging), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Config']/method[@name='setDebugLogging' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("setDebugLogging", "(Ljava/lang/Boolean;)V", "GetSetDebugLogging_Ljava_lang_Boolean_Handler")]
			set {
				if (id_setDebugLogging_Ljava_lang_Boolean_ == IntPtr.Zero)
					id_setDebugLogging_Ljava_lang_Boolean_ = JNIEnv.GetStaticMethodID (class_ref, "setDebugLogging", "(Ljava/lang/Boolean;)V");
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setDebugLogging_Ljava_lang_Boolean_, new JValue (value));
			}
		}

		static IntPtr id_getLifetimeValue;
		public static global::Java.Math.BigDecimal LifetimeValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Config']/method[@name='getLifetimeValue' and count(parameter)=0]"
			[Register ("getLifetimeValue", "()Ljava/math/BigDecimal;", "GetGetLifetimeValueHandler")]
			get {
				if (id_getLifetimeValue == IntPtr.Zero)
					id_getLifetimeValue = JNIEnv.GetStaticMethodID (class_ref, "getLifetimeValue", "()Ljava/math/BigDecimal;");
				return global::Java.Lang.Object.GetObject<global::Java.Math.BigDecimal> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLifetimeValue), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getPrivacyStatus;
		static IntPtr id_setPrivacyStatus_Lcom_adobe_mobile_MobilePrivacyStatus_;
		public static global::Com.Adobe.Mobile.MobilePrivacyStatus PrivacyStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Config']/method[@name='getPrivacyStatus' and count(parameter)=0]"
			[Register ("getPrivacyStatus", "()Lcom/adobe/mobile/MobilePrivacyStatus;", "GetGetPrivacyStatusHandler")]
			get {
				if (id_getPrivacyStatus == IntPtr.Zero)
					id_getPrivacyStatus = JNIEnv.GetStaticMethodID (class_ref, "getPrivacyStatus", "()Lcom/adobe/mobile/MobilePrivacyStatus;");
				return global::Java.Lang.Object.GetObject<global::Com.Adobe.Mobile.MobilePrivacyStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPrivacyStatus), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Config']/method[@name='setPrivacyStatus' and count(parameter)=1 and parameter[1][@type='com.adobe.mobile.MobilePrivacyStatus']]"
			[Register ("setPrivacyStatus", "(Lcom/adobe/mobile/MobilePrivacyStatus;)V", "GetSetPrivacyStatus_Lcom_adobe_mobile_MobilePrivacyStatus_Handler")]
			set {
				if (id_setPrivacyStatus_Lcom_adobe_mobile_MobilePrivacyStatus_ == IntPtr.Zero)
					id_setPrivacyStatus_Lcom_adobe_mobile_MobilePrivacyStatus_ = JNIEnv.GetStaticMethodID (class_ref, "setPrivacyStatus", "(Lcom/adobe/mobile/MobilePrivacyStatus;)V");
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setPrivacyStatus_Lcom_adobe_mobile_MobilePrivacyStatus_, new JValue (value));
			}
		}

		static IntPtr id_getUserIdentifier;
		static IntPtr id_setUserIdentifier_Ljava_lang_String_;
		public static string UserIdentifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Config']/method[@name='getUserIdentifier' and count(parameter)=0]"
			[Register ("getUserIdentifier", "()Ljava/lang/String;", "GetGetUserIdentifierHandler")]
			get {
				if (id_getUserIdentifier == IntPtr.Zero)
					id_getUserIdentifier = JNIEnv.GetStaticMethodID (class_ref, "getUserIdentifier", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getUserIdentifier), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Config']/method[@name='setUserIdentifier' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUserIdentifier", "(Ljava/lang/String;)V", "GetSetUserIdentifier_Ljava_lang_String_Handler")]
			set {
				if (id_setUserIdentifier_Ljava_lang_String_ == IntPtr.Zero)
					id_setUserIdentifier_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setUserIdentifier", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setUserIdentifier_Ljava_lang_String_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_getVersion;
		public static string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Config']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/lang/String;", "GetGetVersionHandler")]
			get {
				if (id_getVersion == IntPtr.Zero)
					id_getVersion = JNIEnv.GetStaticMethodID (class_ref, "getVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_collectLifecycleData;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Config']/method[@name='collectLifecycleData' and count(parameter)=0]"
		[Register ("collectLifecycleData", "()V", "")]
		public static void CollectLifecycleData ()
		{
			if (id_collectLifecycleData == IntPtr.Zero)
				id_collectLifecycleData = JNIEnv.GetStaticMethodID (class_ref, "collectLifecycleData", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_collectLifecycleData);
		}

		static IntPtr id_collectLifecycleData_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Config']/method[@name='collectLifecycleData' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("collectLifecycleData", "(Landroid/app/Activity;)V", "")]
		public static void CollectLifecycleData (global::Android.App.Activity p0)
		{
			if (id_collectLifecycleData_Landroid_app_Activity_ == IntPtr.Zero)
				id_collectLifecycleData_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "collectLifecycleData", "(Landroid/app/Activity;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_collectLifecycleData_Landroid_app_Activity_, new JValue (p0));
		}

		static IntPtr id_overrideConfigStream_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Config']/method[@name='overrideConfigStream' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("overrideConfigStream", "(Ljava/io/InputStream;)V", "")]
		public static void OverrideConfigStream (global::System.IO.Stream p0)
		{
			if (id_overrideConfigStream_Ljava_io_InputStream_ == IntPtr.Zero)
				id_overrideConfigStream_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "overrideConfigStream", "(Ljava/io/InputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_overrideConfigStream_Ljava_io_InputStream_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_pauseCollectingLifecycleData;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Config']/method[@name='pauseCollectingLifecycleData' and count(parameter)=0]"
		[Register ("pauseCollectingLifecycleData", "()V", "")]
		public static void PauseCollectingLifecycleData ()
		{
			if (id_pauseCollectingLifecycleData == IntPtr.Zero)
				id_pauseCollectingLifecycleData = JNIEnv.GetStaticMethodID (class_ref, "pauseCollectingLifecycleData", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_pauseCollectingLifecycleData);
		}

		static IntPtr id_setContext_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Config']/method[@name='setContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("setContext", "(Landroid/content/Context;)V", "")]
		public static void SetContext (global::Android.Content.Context p0)
		{
			if (id_setContext_Landroid_content_Context_ == IntPtr.Zero)
				id_setContext_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "setContext", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setContext_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_setLargeIconResourceId_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Config']/method[@name='setLargeIconResourceId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLargeIconResourceId", "(I)V", "")]
		public static void SetLargeIconResourceId (int p0)
		{
			if (id_setLargeIconResourceId_I == IntPtr.Zero)
				id_setLargeIconResourceId_I = JNIEnv.GetStaticMethodID (class_ref, "setLargeIconResourceId", "(I)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setLargeIconResourceId_I, new JValue (p0));
		}

		static IntPtr id_setSmallIconResourceId_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Config']/method[@name='setSmallIconResourceId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSmallIconResourceId", "(I)V", "")]
		public static void SetSmallIconResourceId (int p0)
		{
			if (id_setSmallIconResourceId_I == IntPtr.Zero)
				id_setSmallIconResourceId_I = JNIEnv.GetStaticMethodID (class_ref, "setSmallIconResourceId", "(I)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setSmallIconResourceId_I, new JValue (p0));
		}

	}
}
