using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Adobe.Mobile {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.adobe.mobile']/class[@name='AudienceManager']"
	[global::Android.Runtime.Register ("com/adobe/mobile/AudienceManager", DoNotGenerateAcw=true)]
	public sealed partial class AudienceManager : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.adobe.mobile']/interface[@name='AudienceManager.AudienceManagerCallback']"
		[Register ("com/adobe/mobile/AudienceManager$AudienceManagerCallback", "", "Com.Adobe.Mobile.AudienceManager/IAudienceManagerCallbackInvoker")]
		public partial interface IAudienceManagerCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/interface[@name='AudienceManager.AudienceManagerCallback']/method[@name='call' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("call", "(Ljava/lang/Object;)V", "GetCall_Ljava_lang_Object_Handler:Com.Adobe.Mobile.AudienceManager/IAudienceManagerCallbackInvoker, AdobeTestAndroid")]
			void Call (global::Java.Lang.Object p0);

		}

		[global::Android.Runtime.Register ("com/adobe/mobile/AudienceManager$AudienceManagerCallback", DoNotGenerateAcw=true)]
		internal class IAudienceManagerCallbackInvoker : global::Java.Lang.Object, IAudienceManagerCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/adobe/mobile/AudienceManager$AudienceManagerCallback");
			IntPtr class_ref;

			public static IAudienceManagerCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IAudienceManagerCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.adobe.mobile.AudienceManager.AudienceManagerCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IAudienceManagerCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IAudienceManagerCallbackInvoker); }
			}

			static Delegate cb_call_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetCall_Ljava_lang_Object_Handler ()
			{
				if (cb_call_Ljava_lang_Object_ == null)
					cb_call_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Call_Ljava_lang_Object_);
				return cb_call_Ljava_lang_Object_;
			}

			static void n_Call_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Adobe.Mobile.AudienceManager.IAudienceManagerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Adobe.Mobile.AudienceManager.IAudienceManagerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Call (p0);
			}
#pragma warning restore 0169

			IntPtr id_call_Ljava_lang_Object_;
			public void Call (global::Java.Lang.Object p0)
			{
				if (id_call_Ljava_lang_Object_ == IntPtr.Zero)
					id_call_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "call", "(Ljava/lang/Object;)V");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				JNIEnv.CallVoidMethod (Handle, id_call_Ljava_lang_Object_, new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/adobe/mobile/AudienceManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AudienceManager); }
		}

		internal AudienceManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.adobe.mobile']/class[@name='AudienceManager']/constructor[@name='AudienceManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public AudienceManager () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AudienceManager)) {
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

		static IntPtr id_getDpid;
		public static string Dpid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='AudienceManager']/method[@name='getDpid' and count(parameter)=0]"
			[Register ("getDpid", "()Ljava/lang/String;", "GetGetDpidHandler")]
			get {
				if (id_getDpid == IntPtr.Zero)
					id_getDpid = JNIEnv.GetStaticMethodID (class_ref, "getDpid", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDpid), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getDpuuid;
		public static string Dpuuid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='AudienceManager']/method[@name='getDpuuid' and count(parameter)=0]"
			[Register ("getDpuuid", "()Ljava/lang/String;", "GetGetDpuuidHandler")]
			get {
				if (id_getDpuuid == IntPtr.Zero)
					id_getDpuuid = JNIEnv.GetStaticMethodID (class_ref, "getDpuuid", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDpuuid), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getVisitorProfile;
		public static global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> VisitorProfile {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='AudienceManager']/method[@name='getVisitorProfile' and count(parameter)=0]"
			[Register ("getVisitorProfile", "()Ljava/util/HashMap;", "GetGetVisitorProfileHandler")]
			get {
				if (id_getVisitorProfile == IntPtr.Zero)
					id_getVisitorProfile = JNIEnv.GetStaticMethodID (class_ref, "getVisitorProfile", "()Ljava/util/HashMap;");
				return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getVisitorProfile), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='AudienceManager']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "")]
		public static void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetStaticMethodID (class_ref, "reset", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_reset);
		}

		static IntPtr id_setDpidAndDpuuid_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='AudienceManager']/method[@name='setDpidAndDpuuid' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setDpidAndDpuuid", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static void SetDpidAndDpuuid (string p0, string p1)
		{
			if (id_setDpidAndDpuuid_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setDpidAndDpuuid_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setDpidAndDpuuid", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setDpidAndDpuuid_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_signalWithData_Ljava_util_Map_Lcom_adobe_mobile_AudienceManager_AudienceManagerCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='AudienceManager']/method[@name='signalWithData' and count(parameter)=2 and parameter[1][@type='java.util.Map'] and parameter[2][@type='com.adobe.mobile.AudienceManager.AudienceManagerCallback']]"
		[Register ("signalWithData", "(Ljava/util/Map;Lcom/adobe/mobile/AudienceManager$AudienceManagerCallback;)V", "")]
		public static void SignalWithData (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0, global::Com.Adobe.Mobile.AudienceManager.IAudienceManagerCallback p1)
		{
			if (id_signalWithData_Ljava_util_Map_Lcom_adobe_mobile_AudienceManager_AudienceManagerCallback_ == IntPtr.Zero)
				id_signalWithData_Ljava_util_Map_Lcom_adobe_mobile_AudienceManager_AudienceManagerCallback_ = JNIEnv.GetStaticMethodID (class_ref, "signalWithData", "(Ljava/util/Map;Lcom/adobe/mobile/AudienceManager$AudienceManagerCallback;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_signalWithData_Ljava_util_Map_Lcom_adobe_mobile_AudienceManager_AudienceManagerCallback_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
