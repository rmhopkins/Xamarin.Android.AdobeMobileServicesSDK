using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Adobe.Mobile {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Target']"
	[global::Android.Runtime.Register ("com/adobe/mobile/Target", DoNotGenerateAcw=true)]
	public sealed partial class Target : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.adobe.mobile']/interface[@name='Target.TargetCallback']"
		[Register ("com/adobe/mobile/Target$TargetCallback", "", "Com.Adobe.Mobile.Target/ITargetCallbackInvoker")]
		public partial interface ITargetCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/interface[@name='Target.TargetCallback']/method[@name='call' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("call", "(Ljava/lang/Object;)V", "GetCall_Ljava_lang_Object_Handler:Com.Adobe.Mobile.Target/ITargetCallbackInvoker, AdobeTestAndroid")]
			void Call (global::Java.Lang.Object p0);

		}

		[global::Android.Runtime.Register ("com/adobe/mobile/Target$TargetCallback", DoNotGenerateAcw=true)]
		internal class ITargetCallbackInvoker : global::Java.Lang.Object, ITargetCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/adobe/mobile/Target$TargetCallback");
			IntPtr class_ref;

			public static ITargetCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ITargetCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.adobe.mobile.Target.TargetCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ITargetCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (ITargetCallbackInvoker); }
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
				global::Com.Adobe.Mobile.Target.ITargetCallback __this = global::Java.Lang.Object.GetObject<global::Com.Adobe.Mobile.Target.ITargetCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				return JNIEnv.FindClass ("com/adobe/mobile/Target", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Target); }
		}

		internal Target (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Target']/constructor[@name='Target' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Target () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Target)) {
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

		static IntPtr id_getPcID;
		public static string PcID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Target']/method[@name='getPcID' and count(parameter)=0]"
			[Register ("getPcID", "()Ljava/lang/String;", "GetGetPcIDHandler")]
			get {
				if (id_getPcID == IntPtr.Zero)
					id_getPcID = JNIEnv.GetStaticMethodID (class_ref, "getPcID", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPcID), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getSessionID;
		public static string SessionID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Target']/method[@name='getSessionID' and count(parameter)=0]"
			[Register ("getSessionID", "()Ljava/lang/String;", "GetGetSessionIDHandler")]
			get {
				if (id_getSessionID == IntPtr.Zero)
					id_getSessionID = JNIEnv.GetStaticMethodID (class_ref, "getSessionID", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSessionID), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_clearCookies;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Target']/method[@name='clearCookies' and count(parameter)=0]"
		[Register ("clearCookies", "()V", "")]
		public static void ClearCookies ()
		{
			if (id_clearCookies == IntPtr.Zero)
				id_clearCookies = JNIEnv.GetStaticMethodID (class_ref, "clearCookies", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_clearCookies);
		}

		static IntPtr id_createOrderConfirmRequest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Target']/method[@name='createOrderConfirmRequest' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.util.Map']]"
		[Register ("createOrderConfirmRequest", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)Lcom/adobe/mobile/TargetLocationRequest;", "")]
		public static global::Com.Adobe.Mobile.TargetLocationRequest CreateOrderConfirmRequest (string p0, string p1, string p2, string p3, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p4)
		{
			if (id_createOrderConfirmRequest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_createOrderConfirmRequest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "createOrderConfirmRequest", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)Lcom/adobe/mobile/TargetLocationRequest;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p4);
			global::Com.Adobe.Mobile.TargetLocationRequest __ret = global::Java.Lang.Object.GetObject<global::Com.Adobe.Mobile.TargetLocationRequest> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createOrderConfirmRequest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p4);
			return __ret;
		}

		static IntPtr id_createRequest_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Target']/method[@name='createRequest' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map']]"
		[Register ("createRequest", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)Lcom/adobe/mobile/TargetLocationRequest;", "")]
		public static global::Com.Adobe.Mobile.TargetLocationRequest CreateRequest (string p0, string p1, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p2)
		{
			if (id_createRequest_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_createRequest_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "createRequest", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)Lcom/adobe/mobile/TargetLocationRequest;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p2);
			global::Com.Adobe.Mobile.TargetLocationRequest __ret = global::Java.Lang.Object.GetObject<global::Com.Adobe.Mobile.TargetLocationRequest> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createRequest_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static IntPtr id_loadRequest_Lcom_adobe_mobile_TargetLocationRequest_Lcom_adobe_mobile_Target_TargetCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Target']/method[@name='loadRequest' and count(parameter)=2 and parameter[1][@type='com.adobe.mobile.TargetLocationRequest'] and parameter[2][@type='com.adobe.mobile.Target.TargetCallback']]"
		[Register ("loadRequest", "(Lcom/adobe/mobile/TargetLocationRequest;Lcom/adobe/mobile/Target$TargetCallback;)V", "")]
		public static void LoadRequest (global::Com.Adobe.Mobile.TargetLocationRequest p0, global::Com.Adobe.Mobile.Target.ITargetCallback p1)
		{
			if (id_loadRequest_Lcom_adobe_mobile_TargetLocationRequest_Lcom_adobe_mobile_Target_TargetCallback_ == IntPtr.Zero)
				id_loadRequest_Lcom_adobe_mobile_TargetLocationRequest_Lcom_adobe_mobile_Target_TargetCallback_ = JNIEnv.GetStaticMethodID (class_ref, "loadRequest", "(Lcom/adobe/mobile/TargetLocationRequest;Lcom/adobe/mobile/Target$TargetCallback;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_loadRequest_Lcom_adobe_mobile_TargetLocationRequest_Lcom_adobe_mobile_Target_TargetCallback_, new JValue (p0), new JValue (p1));
		}

	}
}
