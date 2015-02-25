using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Adobe.Mobile {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.adobe.mobile']/class[@name='TargetLocationRequest']"
	[global::Android.Runtime.Register ("com/adobe/mobile/TargetLocationRequest", DoNotGenerateAcw=true)]
	public partial class TargetLocationRequest : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='TargetLocationRequest']/field[@name='TARGET_PARAMETER_CATEGORY_ID']"
		[Register ("TARGET_PARAMETER_CATEGORY_ID")]
		public const string TargetParameterCategoryId = (string) "categoryId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='TargetLocationRequest']/field[@name='TARGET_PARAMETER_MBOX_3RDPARTY_ID']"
		[Register ("TARGET_PARAMETER_MBOX_3RDPARTY_ID")]
		public const string TargetParameterMbox3rdpartyId = (string) "mbox3rdPartyId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='TargetLocationRequest']/field[@name='TARGET_PARAMETER_MBOX_HOST']"
		[Register ("TARGET_PARAMETER_MBOX_HOST")]
		public const string TargetParameterMboxHost = (string) "mboxHost";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='TargetLocationRequest']/field[@name='TARGET_PARAMETER_MBOX_PAGE_VALUE']"
		[Register ("TARGET_PARAMETER_MBOX_PAGE_VALUE")]
		public const string TargetParameterMboxPageValue = (string) "mboxPageValue";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='TargetLocationRequest']/field[@name='TARGET_PARAMETER_MBOX_PC']"
		[Register ("TARGET_PARAMETER_MBOX_PC")]
		public const string TargetParameterMboxPc = (string) "mboxPC";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='TargetLocationRequest']/field[@name='TARGET_PARAMETER_MBOX_SESSION_ID']"
		[Register ("TARGET_PARAMETER_MBOX_SESSION_ID")]
		public const string TargetParameterMboxSessionId = (string) "mboxSession";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='TargetLocationRequest']/field[@name='TARGET_PARAMETER_ORDER_ID']"
		[Register ("TARGET_PARAMETER_ORDER_ID")]
		public const string TargetParameterOrderId = (string) "orderId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='TargetLocationRequest']/field[@name='TARGET_PARAMETER_ORDER_TOTAL']"
		[Register ("TARGET_PARAMETER_ORDER_TOTAL")]
		public const string TargetParameterOrderTotal = (string) "orderTotal";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='TargetLocationRequest']/field[@name='TARGET_PARAMETER_PRODUCT_PURCHASE_ID']"
		[Register ("TARGET_PARAMETER_PRODUCT_PURCHASE_ID")]
		public const string TargetParameterProductPurchaseId = (string) "productPurchasedId";

		static IntPtr defaultContent_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='TargetLocationRequest']/field[@name='defaultContent']"
		[Register ("defaultContent")]
		public string DefaultContent {
			get {
				if (defaultContent_jfieldId == IntPtr.Zero)
					defaultContent_jfieldId = JNIEnv.GetFieldID (class_ref, "defaultContent", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, defaultContent_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (defaultContent_jfieldId == IntPtr.Zero)
					defaultContent_jfieldId = JNIEnv.GetFieldID (class_ref, "defaultContent", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, defaultContent_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr name_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='TargetLocationRequest']/field[@name='name']"
		[Register ("name")]
		public string Name {
			get {
				if (name_jfieldId == IntPtr.Zero)
					name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, name_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (name_jfieldId == IntPtr.Zero)
					name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, name_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr parameters_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='TargetLocationRequest']/field[@name='parameters']"
		[Register ("parameters")]
		public global::System.Collections.IDictionary Parameters {
			get {
				if (parameters_jfieldId == IntPtr.Zero)
					parameters_jfieldId = JNIEnv.GetFieldID (class_ref, "parameters", "Ljava/util/HashMap;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, parameters_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (parameters_jfieldId == IntPtr.Zero)
					parameters_jfieldId = JNIEnv.GetFieldID (class_ref, "parameters", "Ljava/util/HashMap;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, parameters_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/adobe/mobile/TargetLocationRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TargetLocationRequest); }
		}

		protected TargetLocationRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.adobe.mobile']/class[@name='TargetLocationRequest']/constructor[@name='TargetLocationRequest' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", "")]
		protected TargetLocationRequest (string p0, string p1, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p2);;
			if (GetType () != typeof (TargetLocationRequest)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_createRequestWithOrderConfirm_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='TargetLocationRequest']/method[@name='createRequestWithOrderConfirm' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.util.Map']]"
		[Register ("createRequestWithOrderConfirm", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)Lcom/adobe/mobile/TargetLocationRequest;", "")]
		protected static global::Com.Adobe.Mobile.TargetLocationRequest CreateRequestWithOrderConfirm (string p0, string p1, string p2, string p3, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p4)
		{
			if (id_createRequestWithOrderConfirm_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_createRequestWithOrderConfirm_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "createRequestWithOrderConfirm", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)Lcom/adobe/mobile/TargetLocationRequest;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p4);
			global::Com.Adobe.Mobile.TargetLocationRequest __ret = global::Java.Lang.Object.GetObject<global::Com.Adobe.Mobile.TargetLocationRequest> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createRequestWithOrderConfirm_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p4);
			return __ret;
		}

	}
}
