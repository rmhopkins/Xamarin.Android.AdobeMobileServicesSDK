using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Adobe.Mobile {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MessageFullScreen']"
	[global::Android.Runtime.Register ("com/adobe/mobile/MessageFullScreen", DoNotGenerateAcw=true)]
	public sealed partial class MessageFullScreen : global::Com.Adobe.Mobile.Message {


		static IntPtr html_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MessageFullScreen']/field[@name='html']"
		[Register ("html")]
		protected string Html {
			get {
				if (html_jfieldId == IntPtr.Zero)
					html_jfieldId = JNIEnv.GetFieldID (class_ref, "html", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, html_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (html_jfieldId == IntPtr.Zero)
					html_jfieldId = JNIEnv.GetFieldID (class_ref, "html", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, html_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr messageFullScreenActivity_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MessageFullScreen']/field[@name='messageFullScreenActivity']"
		[Register ("messageFullScreenActivity")]
		protected global::Android.App.Activity MessageFullScreenActivity {
			get {
				if (messageFullScreenActivity_jfieldId == IntPtr.Zero)
					messageFullScreenActivity_jfieldId = JNIEnv.GetFieldID (class_ref, "messageFullScreenActivity", "Landroid/app/Activity;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, messageFullScreenActivity_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (messageFullScreenActivity_jfieldId == IntPtr.Zero)
					messageFullScreenActivity_jfieldId = JNIEnv.GetFieldID (class_ref, "messageFullScreenActivity", "Landroid/app/Activity;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, messageFullScreenActivity_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr replacedHtml_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MessageFullScreen']/field[@name='replacedHtml']"
		[Register ("replacedHtml")]
		protected string ReplacedHtml {
			get {
				if (replacedHtml_jfieldId == IntPtr.Zero)
					replacedHtml_jfieldId = JNIEnv.GetFieldID (class_ref, "replacedHtml", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, replacedHtml_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (replacedHtml_jfieldId == IntPtr.Zero)
					replacedHtml_jfieldId = JNIEnv.GetFieldID (class_ref, "replacedHtml", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, replacedHtml_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr rootViewGroup_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MessageFullScreen']/field[@name='rootViewGroup']"
		[Register ("rootViewGroup")]
		protected global::Android.Views.ViewGroup RootViewGroup {
			get {
				if (rootViewGroup_jfieldId == IntPtr.Zero)
					rootViewGroup_jfieldId = JNIEnv.GetFieldID (class_ref, "rootViewGroup", "Landroid/view/ViewGroup;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, rootViewGroup_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (rootViewGroup_jfieldId == IntPtr.Zero)
					rootViewGroup_jfieldId = JNIEnv.GetFieldID (class_ref, "rootViewGroup", "Landroid/view/ViewGroup;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, rootViewGroup_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MessageFullScreen.MessageFullScreenRunner']"
		[global::Android.Runtime.Register ("com/adobe/mobile/MessageFullScreen$MessageFullScreenRunner", DoNotGenerateAcw=true)]
		public partial class MessageFullScreenRunner : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/adobe/mobile/MessageFullScreen$MessageFullScreenRunner", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MessageFullScreenRunner); }
			}

			protected MessageFullScreenRunner (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_adobe_mobile_MessageFullScreen_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MessageFullScreen.MessageFullScreenRunner']/constructor[@name='MessageFullScreen.MessageFullScreenRunner' and count(parameter)=1 and parameter[1][@type='com.adobe.mobile.MessageFullScreen']]"
			[Register (".ctor", "(Lcom/adobe/mobile/MessageFullScreen;)V", "")]
			protected MessageFullScreenRunner (global::Com.Adobe.Mobile.MessageFullScreen p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (MessageFullScreenRunner)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/adobe/mobile/MessageFullScreen;)V", new JValue (p0)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/adobe/mobile/MessageFullScreen;)V", new JValue (p0));
					return;
				}

				if (id_ctor_Lcom_adobe_mobile_MessageFullScreen_ == IntPtr.Zero)
					id_ctor_Lcom_adobe_mobile_MessageFullScreen_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/adobe/mobile/MessageFullScreen;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_adobe_mobile_MessageFullScreen_, new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_adobe_mobile_MessageFullScreen_, new JValue (p0));
			}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Adobe.Mobile.MessageFullScreen.MessageFullScreenRunner __this = global::Java.Lang.Object.GetObject<global::Com.Adobe.Mobile.MessageFullScreen.MessageFullScreenRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MessageFullScreen.MessageFullScreenRunner']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public virtual void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_run);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MessageFullScreen.MessageFullScreenWebViewClient']"
		[global::Android.Runtime.Register ("com/adobe/mobile/MessageFullScreen$MessageFullScreenWebViewClient", DoNotGenerateAcw=true)]
		public partial class MessageFullScreenWebViewClient : global::Android.Webkit.WebViewClient {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/adobe/mobile/MessageFullScreen$MessageFullScreenWebViewClient", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MessageFullScreenWebViewClient); }
			}

			protected MessageFullScreenWebViewClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_adobe_mobile_MessageFullScreen_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MessageFullScreen.MessageFullScreenWebViewClient']/constructor[@name='MessageFullScreen.MessageFullScreenWebViewClient' and count(parameter)=1 and parameter[1][@type='com.adobe.mobile.MessageFullScreen']]"
			[Register (".ctor", "(Lcom/adobe/mobile/MessageFullScreen;)V", "")]
			protected MessageFullScreenWebViewClient (global::Com.Adobe.Mobile.MessageFullScreen p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (MessageFullScreenWebViewClient)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/adobe/mobile/MessageFullScreen;)V", new JValue (p0)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/adobe/mobile/MessageFullScreen;)V", new JValue (p0));
					return;
				}

				if (id_ctor_Lcom_adobe_mobile_MessageFullScreen_ == IntPtr.Zero)
					id_ctor_Lcom_adobe_mobile_MessageFullScreen_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/adobe/mobile/MessageFullScreen;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_adobe_mobile_MessageFullScreen_, new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_adobe_mobile_MessageFullScreen_, new JValue (p0));
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/adobe/mobile/MessageFullScreen", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessageFullScreen); }
		}

		internal MessageFullScreen (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_initWithPayloadObject_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MessageFullScreen']/method[@name='initWithPayloadObject' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("initWithPayloadObject", "(Lorg/json/JSONObject;)Z", "")]
		protected override bool InitWithPayloadObject (global::Org.Json.JSONObject p0)
		{
			if (id_initWithPayloadObject_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_initWithPayloadObject_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "initWithPayloadObject", "(Lorg/json/JSONObject;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_initWithPayloadObject_Lorg_json_JSONObject_, new JValue (p0));
			return __ret;
		}

		static IntPtr id_show;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MessageFullScreen']/method[@name='show' and count(parameter)=0]"
		[Register ("show", "()V", "")]
		protected override void Show ()
		{
			if (id_show == IntPtr.Zero)
				id_show = JNIEnv.GetMethodID (class_ref, "show", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_show);
		}

		static IntPtr id_showInRootViewGroup;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='MessageFullScreen']/method[@name='showInRootViewGroup' and count(parameter)=0]"
		[Register ("showInRootViewGroup", "()V", "")]
		protected void ShowInRootViewGroup ()
		{
			if (id_showInRootViewGroup == IntPtr.Zero)
				id_showInRootViewGroup = JNIEnv.GetMethodID (class_ref, "showInRootViewGroup", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_showInRootViewGroup);
		}

	}
}
