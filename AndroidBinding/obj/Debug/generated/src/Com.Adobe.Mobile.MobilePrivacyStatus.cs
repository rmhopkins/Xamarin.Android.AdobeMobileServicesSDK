using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Adobe.Mobile {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MobilePrivacyStatus']"
	[global::Android.Runtime.Register ("com/adobe/mobile/MobilePrivacyStatus", DoNotGenerateAcw=true)]
	public sealed partial class MobilePrivacyStatus : global::Java.Lang.Enum {


		static IntPtr MOBILE_PRIVACY_STATUS_OPT_IN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MobilePrivacyStatus']/field[@name='MOBILE_PRIVACY_STATUS_OPT_IN']"
		[Register ("MOBILE_PRIVACY_STATUS_OPT_IN")]
		public static global::Com.Adobe.Mobile.MobilePrivacyStatus MobilePrivacyStatusOptIn {
			get {
				if (MOBILE_PRIVACY_STATUS_OPT_IN_jfieldId == IntPtr.Zero)
					MOBILE_PRIVACY_STATUS_OPT_IN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MOBILE_PRIVACY_STATUS_OPT_IN", "Lcom/adobe/mobile/MobilePrivacyStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MOBILE_PRIVACY_STATUS_OPT_IN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Adobe.Mobile.MobilePrivacyStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (MOBILE_PRIVACY_STATUS_OPT_IN_jfieldId == IntPtr.Zero)
					MOBILE_PRIVACY_STATUS_OPT_IN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MOBILE_PRIVACY_STATUS_OPT_IN", "Lcom/adobe/mobile/MobilePrivacyStatus;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, MOBILE_PRIVACY_STATUS_OPT_IN_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr MOBILE_PRIVACY_STATUS_OPT_OUT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MobilePrivacyStatus']/field[@name='MOBILE_PRIVACY_STATUS_OPT_OUT']"
		[Register ("MOBILE_PRIVACY_STATUS_OPT_OUT")]
		public static global::Com.Adobe.Mobile.MobilePrivacyStatus MobilePrivacyStatusOptOut {
			get {
				if (MOBILE_PRIVACY_STATUS_OPT_OUT_jfieldId == IntPtr.Zero)
					MOBILE_PRIVACY_STATUS_OPT_OUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MOBILE_PRIVACY_STATUS_OPT_OUT", "Lcom/adobe/mobile/MobilePrivacyStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MOBILE_PRIVACY_STATUS_OPT_OUT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Adobe.Mobile.MobilePrivacyStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (MOBILE_PRIVACY_STATUS_OPT_OUT_jfieldId == IntPtr.Zero)
					MOBILE_PRIVACY_STATUS_OPT_OUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MOBILE_PRIVACY_STATUS_OPT_OUT", "Lcom/adobe/mobile/MobilePrivacyStatus;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, MOBILE_PRIVACY_STATUS_OPT_OUT_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr MOBILE_PRIVACY_STATUS_UNKNOWN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MobilePrivacyStatus']/field[@name='MOBILE_PRIVACY_STATUS_UNKNOWN']"
		[Register ("MOBILE_PRIVACY_STATUS_UNKNOWN")]
		public static global::Com.Adobe.Mobile.MobilePrivacyStatus MobilePrivacyStatusUnknown {
			get {
				if (MOBILE_PRIVACY_STATUS_UNKNOWN_jfieldId == IntPtr.Zero)
					MOBILE_PRIVACY_STATUS_UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MOBILE_PRIVACY_STATUS_UNKNOWN", "Lcom/adobe/mobile/MobilePrivacyStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MOBILE_PRIVACY_STATUS_UNKNOWN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Adobe.Mobile.MobilePrivacyStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (MOBILE_PRIVACY_STATUS_UNKNOWN_jfieldId == IntPtr.Zero)
					MOBILE_PRIVACY_STATUS_UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MOBILE_PRIVACY_STATUS_UNKNOWN", "Lcom/adobe/mobile/MobilePrivacyStatus;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, MOBILE_PRIVACY_STATUS_UNKNOWN_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/adobe/mobile/MobilePrivacyStatus", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MobilePrivacyStatus); }
		}

		internal MobilePrivacyStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getValue;
		protected int Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MobilePrivacyStatus']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()I", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getValue);
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MobilePrivacyStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/adobe/mobile/MobilePrivacyStatus;", "")]
		public static global::Com.Adobe.Mobile.MobilePrivacyStatus ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/adobe/mobile/MobilePrivacyStatus;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Com.Adobe.Mobile.MobilePrivacyStatus __ret = global::Java.Lang.Object.GetObject<global::Com.Adobe.Mobile.MobilePrivacyStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MobilePrivacyStatus']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/adobe/mobile/MobilePrivacyStatus;", "")]
		public static global::Com.Adobe.Mobile.MobilePrivacyStatus[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/adobe/mobile/MobilePrivacyStatus;");
			return (global::Com.Adobe.Mobile.MobilePrivacyStatus[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Adobe.Mobile.MobilePrivacyStatus));
		}

	}
}
