using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Adobe.Mobile {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Media']"
	[global::Android.Runtime.Register ("com/adobe/mobile/Media", DoNotGenerateAcw=true)]
	public sealed partial class Media : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.adobe.mobile']/interface[@name='Media.MediaCallback']"
		[Register ("com/adobe/mobile/Media$MediaCallback", "", "Com.Adobe.Mobile.Media/IMediaCallbackInvoker")]
		public partial interface IMediaCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/interface[@name='Media.MediaCallback']/method[@name='call' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("call", "(Ljava/lang/Object;)V", "GetCall_Ljava_lang_Object_Handler:Com.Adobe.Mobile.Media/IMediaCallbackInvoker, AdobeTestAndroid")]
			void Call (global::Java.Lang.Object p0);

		}

		[global::Android.Runtime.Register ("com/adobe/mobile/Media$MediaCallback", DoNotGenerateAcw=true)]
		internal class IMediaCallbackInvoker : global::Java.Lang.Object, IMediaCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/adobe/mobile/Media$MediaCallback");
			IntPtr class_ref;

			public static IMediaCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IMediaCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.adobe.mobile.Media.MediaCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IMediaCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IMediaCallbackInvoker); }
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
				global::Com.Adobe.Mobile.Media.IMediaCallback __this = global::Java.Lang.Object.GetObject<global::Com.Adobe.Mobile.Media.IMediaCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				return JNIEnv.FindClass ("com/adobe/mobile/Media", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Media); }
		}

		internal Media (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Media']/constructor[@name='Media' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Media () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Media)) {
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

		static IntPtr id_adSettingsWith_Ljava_lang_String_DLjava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Media']/method[@name='adSettingsWith' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='double'] and parameter[7][@type='java.lang.String']]"
		[Register ("adSettingsWith", "(Ljava/lang/String;DLjava/lang/String;Ljava/lang/String;Ljava/lang/String;DLjava/lang/String;)Lcom/adobe/mobile/MediaSettings;", "")]
		public static global::Com.Adobe.Mobile.MediaSettings AdSettingsWith (string p0, double p1, string p2, string p3, string p4, double p5, string p6)
		{
			if (id_adSettingsWith_Ljava_lang_String_DLjava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_lang_String_ == IntPtr.Zero)
				id_adSettingsWith_Ljava_lang_String_DLjava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "adSettingsWith", "(Ljava/lang/String;DLjava/lang/String;Ljava/lang/String;Ljava/lang/String;DLjava/lang/String;)Lcom/adobe/mobile/MediaSettings;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			global::Com.Adobe.Mobile.MediaSettings __ret = global::Java.Lang.Object.GetObject<global::Com.Adobe.Mobile.MediaSettings> (JNIEnv.CallStaticObjectMethod  (class_ref, id_adSettingsWith_Ljava_lang_String_DLjava_lang_String_Ljava_lang_String_Ljava_lang_String_DLjava_lang_String_, new JValue (native_p0), new JValue (p1), new JValue (native_p2), new JValue (native_p3), new JValue (native_p4), new JValue (p5), new JValue (native_p6)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p4);
			JNIEnv.DeleteLocalRef (native_p6);
			return __ret;
		}

		static IntPtr id_click_Ljava_lang_String_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Media']/method[@name='click' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double']]"
		[Register ("click", "(Ljava/lang/String;D)V", "")]
		public static void Click (string p0, double p1)
		{
			if (id_click_Ljava_lang_String_D == IntPtr.Zero)
				id_click_Ljava_lang_String_D = JNIEnv.GetStaticMethodID (class_ref, "click", "(Ljava/lang/String;D)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_click_Ljava_lang_String_D, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_close_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Media']/method[@name='close' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("close", "(Ljava/lang/String;)V", "")]
		public static void Close (string p0)
		{
			if (id_close_Ljava_lang_String_ == IntPtr.Zero)
				id_close_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "close", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_close_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_complete_Ljava_lang_String_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Media']/method[@name='complete' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double']]"
		[Register ("complete", "(Ljava/lang/String;D)V", "")]
		public static void Complete (string p0, double p1)
		{
			if (id_complete_Ljava_lang_String_D == IntPtr.Zero)
				id_complete_Ljava_lang_String_D = JNIEnv.GetStaticMethodID (class_ref, "complete", "(Ljava/lang/String;D)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_complete_Ljava_lang_String_D, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_open_Lcom_adobe_mobile_MediaSettings_Lcom_adobe_mobile_Media_MediaCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Media']/method[@name='open' and count(parameter)=2 and parameter[1][@type='com.adobe.mobile.MediaSettings'] and parameter[2][@type='com.adobe.mobile.Media.MediaCallback']]"
		[Register ("open", "(Lcom/adobe/mobile/MediaSettings;Lcom/adobe/mobile/Media$MediaCallback;)V", "")]
		public static void Open (global::Com.Adobe.Mobile.MediaSettings p0, global::Com.Adobe.Mobile.Media.IMediaCallback p1)
		{
			if (id_open_Lcom_adobe_mobile_MediaSettings_Lcom_adobe_mobile_Media_MediaCallback_ == IntPtr.Zero)
				id_open_Lcom_adobe_mobile_MediaSettings_Lcom_adobe_mobile_Media_MediaCallback_ = JNIEnv.GetStaticMethodID (class_ref, "open", "(Lcom/adobe/mobile/MediaSettings;Lcom/adobe/mobile/Media$MediaCallback;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_open_Lcom_adobe_mobile_MediaSettings_Lcom_adobe_mobile_Media_MediaCallback_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_play_Ljava_lang_String_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Media']/method[@name='play' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double']]"
		[Register ("play", "(Ljava/lang/String;D)V", "")]
		public static void Play (string p0, double p1)
		{
			if (id_play_Ljava_lang_String_D == IntPtr.Zero)
				id_play_Ljava_lang_String_D = JNIEnv.GetStaticMethodID (class_ref, "play", "(Ljava/lang/String;D)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_play_Ljava_lang_String_D, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_settingsWith_Ljava_lang_String_DLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Media']/method[@name='settingsWith' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("settingsWith", "(Ljava/lang/String;DLjava/lang/String;Ljava/lang/String;)Lcom/adobe/mobile/MediaSettings;", "")]
		public static global::Com.Adobe.Mobile.MediaSettings SettingsWith (string p0, double p1, string p2, string p3)
		{
			if (id_settingsWith_Ljava_lang_String_DLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_settingsWith_Ljava_lang_String_DLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "settingsWith", "(Ljava/lang/String;DLjava/lang/String;Ljava/lang/String;)Lcom/adobe/mobile/MediaSettings;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			global::Com.Adobe.Mobile.MediaSettings __ret = global::Java.Lang.Object.GetObject<global::Com.Adobe.Mobile.MediaSettings> (JNIEnv.CallStaticObjectMethod  (class_ref, id_settingsWith_Ljava_lang_String_DLjava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (p1), new JValue (native_p2), new JValue (native_p3)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			return __ret;
		}

		static IntPtr id_stop_Ljava_lang_String_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Media']/method[@name='stop' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double']]"
		[Register ("stop", "(Ljava/lang/String;D)V", "")]
		public static void Stop (string p0, double p1)
		{
			if (id_stop_Ljava_lang_String_D == IntPtr.Zero)
				id_stop_Ljava_lang_String_D = JNIEnv.GetStaticMethodID (class_ref, "stop", "(Ljava/lang/String;D)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_stop_Ljava_lang_String_D, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_track_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Media']/method[@name='track' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map']]"
		[Register ("track", "(Ljava/lang/String;Ljava/util/Map;)V", "")]
		public static void Track (string p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1)
		{
			if (id_track_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_track_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "track", "(Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_track_Ljava_lang_String_Ljava_util_Map_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}
}
