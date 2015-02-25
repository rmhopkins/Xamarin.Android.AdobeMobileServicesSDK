using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Adobe.Mobile {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Message']"
	[global::Android.Runtime.Register ("com/adobe/mobile/Message", DoNotGenerateAcw=true)]
	public abstract partial class Message : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Message']/field[@name='JSON_CONFIG_ASSETS']"
		[Register ("JSON_CONFIG_ASSETS")]
		protected const string JsonConfigAssets = (string) "assets";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Message']/field[@name='MESSAGE_IMAGE_CACHE_DIR']"
		[Register ("MESSAGE_IMAGE_CACHE_DIR")]
		protected const string MessageImageCacheDir = (string) "messageImages";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Message']/field[@name='MESSAGE_JSON_PAYLOAD']"
		[Register ("MESSAGE_JSON_PAYLOAD")]
		protected const string MessageJsonPayload = (string) "payload";

		static IntPtr assets_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Message']/field[@name='assets']"
		[Register ("assets")]
		protected global::System.Collections.IList Assets {
			get {
				if (assets_jfieldId == IntPtr.Zero)
					assets_jfieldId = JNIEnv.GetFieldID (class_ref, "assets", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, assets_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (assets_jfieldId == IntPtr.Zero)
					assets_jfieldId = JNIEnv.GetFieldID (class_ref, "assets", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, assets_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr audiences_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Message']/field[@name='audiences']"
		[Register ("audiences")]
		protected global::System.Collections.IList Audiences {
			get {
				if (audiences_jfieldId == IntPtr.Zero)
					audiences_jfieldId = JNIEnv.GetFieldID (class_ref, "audiences", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, audiences_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (audiences_jfieldId == IntPtr.Zero)
					audiences_jfieldId = JNIEnv.GetFieldID (class_ref, "audiences", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, audiences_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr endDate_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Message']/field[@name='endDate']"
		[Register ("endDate")]
		protected global::Java.Util.Date EndDate {
			get {
				if (endDate_jfieldId == IntPtr.Zero)
					endDate_jfieldId = JNIEnv.GetFieldID (class_ref, "endDate", "Ljava/util/Date;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, endDate_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (endDate_jfieldId == IntPtr.Zero)
					endDate_jfieldId = JNIEnv.GetFieldID (class_ref, "endDate", "Ljava/util/Date;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, endDate_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr isVisible_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Message']/field[@name='isVisible']"
		[Register ("isVisible")]
		protected bool IsVisible {
			get {
				if (isVisible_jfieldId == IntPtr.Zero)
					isVisible_jfieldId = JNIEnv.GetFieldID (class_ref, "isVisible", "Z");
				return JNIEnv.GetBooleanField (Handle, isVisible_jfieldId);
			}
			set {
				if (isVisible_jfieldId == IntPtr.Zero)
					isVisible_jfieldId = JNIEnv.GetFieldID (class_ref, "isVisible", "Z");
				JNIEnv.SetField (Handle, isVisible_jfieldId, value);
			}
		}

		static IntPtr messageId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Message']/field[@name='messageId']"
		[Register ("messageId")]
		protected string MessageId {
			get {
				if (messageId_jfieldId == IntPtr.Zero)
					messageId_jfieldId = JNIEnv.GetFieldID (class_ref, "messageId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, messageId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (messageId_jfieldId == IntPtr.Zero)
					messageId_jfieldId = JNIEnv.GetFieldID (class_ref, "messageId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, messageId_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr orientationWhenShown_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Message']/field[@name='orientationWhenShown']"
		[Register ("orientationWhenShown")]
		protected int OrientationWhenShown {
			get {
				if (orientationWhenShown_jfieldId == IntPtr.Zero)
					orientationWhenShown_jfieldId = JNIEnv.GetFieldID (class_ref, "orientationWhenShown", "I");
				return JNIEnv.GetIntField (Handle, orientationWhenShown_jfieldId);
			}
			set {
				if (orientationWhenShown_jfieldId == IntPtr.Zero)
					orientationWhenShown_jfieldId = JNIEnv.GetFieldID (class_ref, "orientationWhenShown", "I");
				JNIEnv.SetField (Handle, orientationWhenShown_jfieldId, value);
			}
		}

		static IntPtr showOffline_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Message']/field[@name='showOffline']"
		[Register ("showOffline")]
		protected bool ShowOffline {
			get {
				if (showOffline_jfieldId == IntPtr.Zero)
					showOffline_jfieldId = JNIEnv.GetFieldID (class_ref, "showOffline", "Z");
				return JNIEnv.GetBooleanField (Handle, showOffline_jfieldId);
			}
			set {
				if (showOffline_jfieldId == IntPtr.Zero)
					showOffline_jfieldId = JNIEnv.GetFieldID (class_ref, "showOffline", "Z");
				JNIEnv.SetField (Handle, showOffline_jfieldId, value);
			}
		}

		static IntPtr startDate_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Message']/field[@name='startDate']"
		[Register ("startDate")]
		protected global::Java.Util.Date StartDate {
			get {
				if (startDate_jfieldId == IntPtr.Zero)
					startDate_jfieldId = JNIEnv.GetFieldID (class_ref, "startDate", "Ljava/util/Date;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, startDate_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (startDate_jfieldId == IntPtr.Zero)
					startDate_jfieldId = JNIEnv.GetFieldID (class_ref, "startDate", "Ljava/util/Date;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, startDate_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr triggers_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Message']/field[@name='triggers']"
		[Register ("triggers")]
		protected global::System.Collections.IList Triggers {
			get {
				if (triggers_jfieldId == IntPtr.Zero)
					triggers_jfieldId = JNIEnv.GetFieldID (class_ref, "triggers", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, triggers_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (triggers_jfieldId == IntPtr.Zero)
					triggers_jfieldId = JNIEnv.GetFieldID (class_ref, "triggers", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, triggers_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/adobe/mobile/Message", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Message); }
		}

		protected Message (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_isBlacklisted;
#pragma warning disable 0169
		static Delegate GetIsBlacklistedHandler ()
		{
			if (cb_isBlacklisted == null)
				cb_isBlacklisted = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBlacklisted);
			return cb_isBlacklisted;
		}

		static bool n_IsBlacklisted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Adobe.Mobile.Message __this = global::Java.Lang.Object.GetObject<global::Com.Adobe.Mobile.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBlacklisted;
		}
#pragma warning restore 0169

		static IntPtr id_isBlacklisted;
		protected virtual bool IsBlacklisted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Message']/method[@name='isBlacklisted' and count(parameter)=0]"
			[Register ("isBlacklisted", "()Z", "GetIsBlacklistedHandler")]
			get {
				if (id_isBlacklisted == IntPtr.Zero)
					id_isBlacklisted = JNIEnv.GetMethodID (class_ref, "isBlacklisted", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isBlacklisted);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isBlacklisted", "()Z"));
			}
		}

		static Delegate cb_blacklist;
#pragma warning disable 0169
		static Delegate GetBlacklistHandler ()
		{
			if (cb_blacklist == null)
				cb_blacklist = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Blacklist);
			return cb_blacklist;
		}

		static void n_Blacklist (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Adobe.Mobile.Message __this = global::Java.Lang.Object.GetObject<global::Com.Adobe.Mobile.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Blacklist ();
		}
#pragma warning restore 0169

		static IntPtr id_blacklist;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Message']/method[@name='blacklist' and count(parameter)=0]"
		[Register ("blacklist", "()V", "GetBlacklistHandler")]
		protected virtual void Blacklist ()
		{
			if (id_blacklist == IntPtr.Zero)
				id_blacklist = JNIEnv.GetMethodID (class_ref, "blacklist", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_blacklist);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "blacklist", "()V"));
		}

		static Delegate cb_clickedThrough;
#pragma warning disable 0169
		static Delegate GetClickedThroughHandler ()
		{
			if (cb_clickedThrough == null)
				cb_clickedThrough = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClickedThrough);
			return cb_clickedThrough;
		}

		static void n_ClickedThrough (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Adobe.Mobile.Message __this = global::Java.Lang.Object.GetObject<global::Com.Adobe.Mobile.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClickedThrough ();
		}
#pragma warning restore 0169

		static IntPtr id_clickedThrough;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Message']/method[@name='clickedThrough' and count(parameter)=0]"
		[Register ("clickedThrough", "()V", "GetClickedThroughHandler")]
		protected virtual void ClickedThrough ()
		{
			if (id_clickedThrough == IntPtr.Zero)
				id_clickedThrough = JNIEnv.GetMethodID (class_ref, "clickedThrough", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_clickedThrough);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clickedThrough", "()V"));
		}

		static Delegate cb_description;
#pragma warning disable 0169
		static Delegate GetDescriptionHandler ()
		{
			if (cb_description == null)
				cb_description = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Description);
			return cb_description;
		}

		static IntPtr n_Description (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Adobe.Mobile.Message __this = global::Java.Lang.Object.GetObject<global::Com.Adobe.Mobile.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Description ());
		}
#pragma warning restore 0169

		static IntPtr id_description;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Message']/method[@name='description' and count(parameter)=0]"
		[Register ("description", "()Ljava/lang/String;", "GetDescriptionHandler")]
		protected virtual string Description ()
		{
			if (id_description == IntPtr.Zero)
				id_description = JNIEnv.GetMethodID (class_ref, "description", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_description), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "description", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_initWithPayloadObject_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetInitWithPayloadObject_Lorg_json_JSONObject_Handler ()
		{
			if (cb_initWithPayloadObject_Lorg_json_JSONObject_ == null)
				cb_initWithPayloadObject_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_InitWithPayloadObject_Lorg_json_JSONObject_);
			return cb_initWithPayloadObject_Lorg_json_JSONObject_;
		}

		static bool n_InitWithPayloadObject_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Adobe.Mobile.Message __this = global::Java.Lang.Object.GetObject<global::Com.Adobe.Mobile.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.InitWithPayloadObject (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_initWithPayloadObject_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Message']/method[@name='initWithPayloadObject' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("initWithPayloadObject", "(Lorg/json/JSONObject;)Z", "GetInitWithPayloadObject_Lorg_json_JSONObject_Handler")]
		protected virtual bool InitWithPayloadObject (global::Org.Json.JSONObject p0)
		{
			if (id_initWithPayloadObject_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_initWithPayloadObject_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "initWithPayloadObject", "(Lorg/json/JSONObject;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_initWithPayloadObject_Lorg_json_JSONObject_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initWithPayloadObject", "(Lorg/json/JSONObject;)Z"), new JValue (p0));
			return __ret;
		}

		static Delegate cb_shouldShowForVariables_Ljava_util_Map_Ljava_util_Map_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetShouldShowForVariables_Ljava_util_Map_Ljava_util_Map_Ljava_util_Map_Handler ()
		{
			if (cb_shouldShowForVariables_Ljava_util_Map_Ljava_util_Map_Ljava_util_Map_ == null)
				cb_shouldShowForVariables_Ljava_util_Map_Ljava_util_Map_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_ShouldShowForVariables_Ljava_util_Map_Ljava_util_Map_Ljava_util_Map_);
			return cb_shouldShowForVariables_Ljava_util_Map_Ljava_util_Map_Ljava_util_Map_;
		}

		static bool n_ShouldShowForVariables_Ljava_util_Map_Ljava_util_Map_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Adobe.Mobile.Message __this = global::Java.Lang.Object.GetObject<global::Com.Adobe.Mobile.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, Java.Lang.Object> p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, Java.Lang.Object> p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, Java.Lang.Object> p2 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ShouldShowForVariables (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_shouldShowForVariables_Ljava_util_Map_Ljava_util_Map_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Message']/method[@name='shouldShowForVariables' and count(parameter)=3 and parameter[1][@type='java.util.Map'] and parameter[2][@type='java.util.Map'] and parameter[3][@type='java.util.Map']]"
		[Register ("shouldShowForVariables", "(Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;)Z", "GetShouldShowForVariables_Ljava_util_Map_Ljava_util_Map_Ljava_util_Map_Handler")]
		protected virtual bool ShouldShowForVariables (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p2)
		{
			if (id_shouldShowForVariables_Ljava_util_Map_Ljava_util_Map_Ljava_util_Map_ == IntPtr.Zero)
				id_shouldShowForVariables_Ljava_util_Map_Ljava_util_Map_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "shouldShowForVariables", "(Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p2);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_shouldShowForVariables_Ljava_util_Map_Ljava_util_Map_Ljava_util_Map_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shouldShowForVariables", "(Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;)Z"), new JValue (native_p0), new JValue (native_p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate cb_show;
#pragma warning disable 0169
		static Delegate GetShowHandler ()
		{
			if (cb_show == null)
				cb_show = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Show);
			return cb_show;
		}

		static void n_Show (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Adobe.Mobile.Message __this = global::Java.Lang.Object.GetObject<global::Com.Adobe.Mobile.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Show ();
		}
#pragma warning restore 0169

		static IntPtr id_show;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Message']/method[@name='show' and count(parameter)=0]"
		[Register ("show", "()V", "GetShowHandler")]
		protected virtual void Show ()
		{
			if (id_show == IntPtr.Zero)
				id_show = JNIEnv.GetMethodID (class_ref, "show", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_show);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "show", "()V"));
		}

		static Delegate cb_viewed;
#pragma warning disable 0169
		static Delegate GetViewedHandler ()
		{
			if (cb_viewed == null)
				cb_viewed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Viewed);
			return cb_viewed;
		}

		static void n_Viewed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Adobe.Mobile.Message __this = global::Java.Lang.Object.GetObject<global::Com.Adobe.Mobile.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Viewed ();
		}
#pragma warning restore 0169

		static IntPtr id_viewed;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Message']/method[@name='viewed' and count(parameter)=0]"
		[Register ("viewed", "()V", "GetViewedHandler")]
		protected virtual void Viewed ()
		{
			if (id_viewed == IntPtr.Zero)
				id_viewed = JNIEnv.GetMethodID (class_ref, "viewed", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_viewed);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "viewed", "()V"));
		}

	}

	[global::Android.Runtime.Register ("com/adobe/mobile/Message", DoNotGenerateAcw=true)]
	internal partial class MessageInvoker : Message {

		public MessageInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessageInvoker); }
		}

	}

}
