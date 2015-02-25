using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Adobe.Mobile {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Analytics']"
	[global::Android.Runtime.Register ("com/adobe/mobile/Analytics", DoNotGenerateAcw=true)]
	public sealed partial class Analytics : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Analytics.BEACON_PROXIMITY']"
		[global::Android.Runtime.Register ("com/adobe/mobile/Analytics$BEACON_PROXIMITY", DoNotGenerateAcw=true)]
		public sealed partial class BEACON_PROXIMITY : global::Java.Lang.Enum {


			static IntPtr PROXIMITY_FAR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Analytics.BEACON_PROXIMITY']/field[@name='PROXIMITY_FAR']"
			[Register ("PROXIMITY_FAR")]
			public static global::Com.Adobe.Mobile.Analytics.BEACON_PROXIMITY ProximityFar {
				get {
					if (PROXIMITY_FAR_jfieldId == IntPtr.Zero)
						PROXIMITY_FAR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROXIMITY_FAR", "Lcom/adobe/mobile/Analytics$BEACON_PROXIMITY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PROXIMITY_FAR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Adobe.Mobile.Analytics.BEACON_PROXIMITY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (PROXIMITY_FAR_jfieldId == IntPtr.Zero)
						PROXIMITY_FAR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROXIMITY_FAR", "Lcom/adobe/mobile/Analytics$BEACON_PROXIMITY;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, PROXIMITY_FAR_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr PROXIMITY_IMMEDIATE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Analytics.BEACON_PROXIMITY']/field[@name='PROXIMITY_IMMEDIATE']"
			[Register ("PROXIMITY_IMMEDIATE")]
			public static global::Com.Adobe.Mobile.Analytics.BEACON_PROXIMITY ProximityImmediate {
				get {
					if (PROXIMITY_IMMEDIATE_jfieldId == IntPtr.Zero)
						PROXIMITY_IMMEDIATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROXIMITY_IMMEDIATE", "Lcom/adobe/mobile/Analytics$BEACON_PROXIMITY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PROXIMITY_IMMEDIATE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Adobe.Mobile.Analytics.BEACON_PROXIMITY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (PROXIMITY_IMMEDIATE_jfieldId == IntPtr.Zero)
						PROXIMITY_IMMEDIATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROXIMITY_IMMEDIATE", "Lcom/adobe/mobile/Analytics$BEACON_PROXIMITY;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, PROXIMITY_IMMEDIATE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr PROXIMITY_NEAR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Analytics.BEACON_PROXIMITY']/field[@name='PROXIMITY_NEAR']"
			[Register ("PROXIMITY_NEAR")]
			public static global::Com.Adobe.Mobile.Analytics.BEACON_PROXIMITY ProximityNear {
				get {
					if (PROXIMITY_NEAR_jfieldId == IntPtr.Zero)
						PROXIMITY_NEAR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROXIMITY_NEAR", "Lcom/adobe/mobile/Analytics$BEACON_PROXIMITY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PROXIMITY_NEAR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Adobe.Mobile.Analytics.BEACON_PROXIMITY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (PROXIMITY_NEAR_jfieldId == IntPtr.Zero)
						PROXIMITY_NEAR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROXIMITY_NEAR", "Lcom/adobe/mobile/Analytics$BEACON_PROXIMITY;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, PROXIMITY_NEAR_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr PROXIMITY_UNKNOWN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Analytics.BEACON_PROXIMITY']/field[@name='PROXIMITY_UNKNOWN']"
			[Register ("PROXIMITY_UNKNOWN")]
			public static global::Com.Adobe.Mobile.Analytics.BEACON_PROXIMITY ProximityUnknown {
				get {
					if (PROXIMITY_UNKNOWN_jfieldId == IntPtr.Zero)
						PROXIMITY_UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROXIMITY_UNKNOWN", "Lcom/adobe/mobile/Analytics$BEACON_PROXIMITY;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PROXIMITY_UNKNOWN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Adobe.Mobile.Analytics.BEACON_PROXIMITY> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (PROXIMITY_UNKNOWN_jfieldId == IntPtr.Zero)
						PROXIMITY_UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROXIMITY_UNKNOWN", "Lcom/adobe/mobile/Analytics$BEACON_PROXIMITY;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, PROXIMITY_UNKNOWN_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/adobe/mobile/Analytics$BEACON_PROXIMITY", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BEACON_PROXIMITY); }
			}

			internal BEACON_PROXIMITY (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Analytics.BEACON_PROXIMITY']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/adobe/mobile/Analytics$BEACON_PROXIMITY;", "")]
			public static global::Com.Adobe.Mobile.Analytics.BEACON_PROXIMITY ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/adobe/mobile/Analytics$BEACON_PROXIMITY;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				global::Com.Adobe.Mobile.Analytics.BEACON_PROXIMITY __ret = global::Java.Lang.Object.GetObject<global::Com.Adobe.Mobile.Analytics.BEACON_PROXIMITY> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Analytics.BEACON_PROXIMITY']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/adobe/mobile/Analytics$BEACON_PROXIMITY;", "")]
			public static global::Com.Adobe.Mobile.Analytics.BEACON_PROXIMITY[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/adobe/mobile/Analytics$BEACON_PROXIMITY;");
				return (global::Com.Adobe.Mobile.Analytics.BEACON_PROXIMITY[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Adobe.Mobile.Analytics.BEACON_PROXIMITY));
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.adobe.mobile']/interface[@name='Analytics.TimedActionBlock']"
		[Register ("com/adobe/mobile/Analytics$TimedActionBlock", "", "Com.Adobe.Mobile.Analytics/ITimedActionBlockInvoker")]
		public partial interface ITimedActionBlock : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/interface[@name='Analytics.TimedActionBlock']/method[@name='call' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='java.util.Map']]"
			[Register ("call", "(JJLjava/util/Map;)Ljava/lang/Object;", "GetCall_JJLjava_util_Map_Handler:Com.Adobe.Mobile.Analytics/ITimedActionBlockInvoker, AdobeTestAndroid")]
			global::Java.Lang.Object Call (long p0, long p1, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p2);

		}

		[global::Android.Runtime.Register ("com/adobe/mobile/Analytics$TimedActionBlock", DoNotGenerateAcw=true)]
		internal class ITimedActionBlockInvoker : global::Java.Lang.Object, ITimedActionBlock {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/adobe/mobile/Analytics$TimedActionBlock");
			IntPtr class_ref;

			public static ITimedActionBlock GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ITimedActionBlock> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.adobe.mobile.Analytics.TimedActionBlock"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ITimedActionBlockInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (ITimedActionBlockInvoker); }
			}

			static Delegate cb_call_JJLjava_util_Map_;
#pragma warning disable 0169
			static Delegate GetCall_JJLjava_util_Map_Handler ()
			{
				if (cb_call_JJLjava_util_Map_ == null)
					cb_call_JJLjava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, long, IntPtr, IntPtr>) n_Call_JJLjava_util_Map_);
				return cb_call_JJLjava_util_Map_;
			}

			static IntPtr n_Call_JJLjava_util_Map_ (IntPtr jnienv, IntPtr native__this, long p0, long p1, IntPtr native_p2)
			{
				global::Com.Adobe.Mobile.Analytics.ITimedActionBlock __this = global::Java.Lang.Object.GetObject<global::Com.Adobe.Mobile.Analytics.ITimedActionBlock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				System.Collections.Generic.IDictionary<string, Java.Lang.Object> p2 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Call (p0, p1, p2));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_call_JJLjava_util_Map_;
			public global::Java.Lang.Object Call (long p0, long p1, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p2)
			{
				if (id_call_JJLjava_util_Map_ == IntPtr.Zero)
					id_call_JJLjava_util_Map_ = JNIEnv.GetMethodID (class_ref, "call", "(JJLjava/util/Map;)Ljava/lang/Object;");
				IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p2);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_call_JJLjava_util_Map_, new JValue (p0), new JValue (p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p2);
				return __ret;
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/adobe/mobile/Analytics", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Analytics); }
		}

		internal Analytics (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Analytics']/constructor[@name='Analytics' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Analytics () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Analytics)) {
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

		static IntPtr id_getQueueSize;
		public static long QueueSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Analytics']/method[@name='getQueueSize' and count(parameter)=0]"
			[Register ("getQueueSize", "()J", "GetGetQueueSizeHandler")]
			get {
				if (id_getQueueSize == IntPtr.Zero)
					id_getQueueSize = JNIEnv.GetStaticMethodID (class_ref, "getQueueSize", "()J");
				return JNIEnv.CallStaticLongMethod  (class_ref, id_getQueueSize);
			}
		}

		static IntPtr id_getTrackingIdentifier;
		public static string TrackingIdentifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Analytics']/method[@name='getTrackingIdentifier' and count(parameter)=0]"
			[Register ("getTrackingIdentifier", "()Ljava/lang/String;", "GetGetTrackingIdentifierHandler")]
			get {
				if (id_getTrackingIdentifier == IntPtr.Zero)
					id_getTrackingIdentifier = JNIEnv.GetStaticMethodID (class_ref, "getTrackingIdentifier", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTrackingIdentifier), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_clearBeacon;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Analytics']/method[@name='clearBeacon' and count(parameter)=0]"
		[Register ("clearBeacon", "()V", "")]
		public static void ClearBeacon ()
		{
			if (id_clearBeacon == IntPtr.Zero)
				id_clearBeacon = JNIEnv.GetStaticMethodID (class_ref, "clearBeacon", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_clearBeacon);
		}

		static IntPtr id_clearQueue;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Analytics']/method[@name='clearQueue' and count(parameter)=0]"
		[Register ("clearQueue", "()V", "")]
		public static void ClearQueue ()
		{
			if (id_clearQueue == IntPtr.Zero)
				id_clearQueue = JNIEnv.GetStaticMethodID (class_ref, "clearQueue", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_clearQueue);
		}

		static IntPtr id_processReferrer_Landroid_content_Context_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Analytics']/method[@name='processReferrer' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("processReferrer", "(Landroid/content/Context;Landroid/content/Intent;)V", "")]
		public static void ProcessReferrer (global::Android.Content.Context p0, global::Android.Content.Intent p1)
		{
			if (id_processReferrer_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
				id_processReferrer_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "processReferrer", "(Landroid/content/Context;Landroid/content/Intent;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_processReferrer_Landroid_content_Context_Landroid_content_Intent_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_sendQueuedHits;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Analytics']/method[@name='sendQueuedHits' and count(parameter)=0]"
		[Register ("sendQueuedHits", "()V", "")]
		public static void SendQueuedHits ()
		{
			if (id_sendQueuedHits == IntPtr.Zero)
				id_sendQueuedHits = JNIEnv.GetStaticMethodID (class_ref, "sendQueuedHits", "()V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_sendQueuedHits);
		}

		static IntPtr id_trackAction_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Analytics']/method[@name='trackAction' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map']]"
		[Register ("trackAction", "(Ljava/lang/String;Ljava/util/Map;)V", "")]
		public static void TrackAction (string p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1)
		{
			if (id_trackAction_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_trackAction_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "trackAction", "(Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_trackAction_Ljava_lang_String_Ljava_util_Map_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_trackBeacon_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_adobe_mobile_Analytics_BEACON_PROXIMITY_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Analytics']/method[@name='trackBeacon' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.adobe.mobile.Analytics.BEACON_PROXIMITY'] and parameter[5][@type='java.util.Map']]"
		[Register ("trackBeacon", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/adobe/mobile/Analytics$BEACON_PROXIMITY;Ljava/util/Map;)V", "")]
		public static void TrackBeacon (string p0, string p1, string p2, global::Com.Adobe.Mobile.Analytics.BEACON_PROXIMITY p3, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p4)
		{
			if (id_trackBeacon_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_adobe_mobile_Analytics_BEACON_PROXIMITY_Ljava_util_Map_ == IntPtr.Zero)
				id_trackBeacon_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_adobe_mobile_Analytics_BEACON_PROXIMITY_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "trackBeacon", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/adobe/mobile/Analytics$BEACON_PROXIMITY;Ljava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p4 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p4);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_trackBeacon_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_adobe_mobile_Analytics_BEACON_PROXIMITY_Ljava_util_Map_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (p3), new JValue (native_p4));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p4);
		}

		static IntPtr id_trackLifetimeValueIncrease_Ljava_math_BigDecimal_Ljava_util_HashMap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Analytics']/method[@name='trackLifetimeValueIncrease' and count(parameter)=2 and parameter[1][@type='java.math.BigDecimal'] and parameter[2][@type='java.util.HashMap']]"
		[Register ("trackLifetimeValueIncrease", "(Ljava/math/BigDecimal;Ljava/util/HashMap;)V", "")]
		public static void TrackLifetimeValueIncrease (global::Java.Math.BigDecimal p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1)
		{
			if (id_trackLifetimeValueIncrease_Ljava_math_BigDecimal_Ljava_util_HashMap_ == IntPtr.Zero)
				id_trackLifetimeValueIncrease_Ljava_math_BigDecimal_Ljava_util_HashMap_ = JNIEnv.GetStaticMethodID (class_ref, "trackLifetimeValueIncrease", "(Ljava/math/BigDecimal;Ljava/util/HashMap;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_trackLifetimeValueIncrease_Ljava_math_BigDecimal_Ljava_util_HashMap_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_trackLocation_Landroid_location_Location_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Analytics']/method[@name='trackLocation' and count(parameter)=2 and parameter[1][@type='android.location.Location'] and parameter[2][@type='java.util.Map']]"
		[Register ("trackLocation", "(Landroid/location/Location;Ljava/util/Map;)V", "")]
		public static void TrackLocation (global::Android.Locations.Location p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1)
		{
			if (id_trackLocation_Landroid_location_Location_Ljava_util_Map_ == IntPtr.Zero)
				id_trackLocation_Landroid_location_Location_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "trackLocation", "(Landroid/location/Location;Ljava/util/Map;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_trackLocation_Landroid_location_Location_Ljava_util_Map_, new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_trackState_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Analytics']/method[@name='trackState' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map']]"
		[Register ("trackState", "(Ljava/lang/String;Ljava/util/Map;)V", "")]
		public static void TrackState (string p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1)
		{
			if (id_trackState_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_trackState_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "trackState", "(Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_trackState_Ljava_lang_String_Ljava_util_Map_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_trackTimedActionEnd_Ljava_lang_String_Lcom_adobe_mobile_Analytics_TimedActionBlock_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Analytics']/method[@name='trackTimedActionEnd' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.adobe.mobile.Analytics.TimedActionBlock']]"
		[Register ("trackTimedActionEnd", "(Ljava/lang/String;Lcom/adobe/mobile/Analytics$TimedActionBlock;)V", "")]
		public static void TrackTimedActionEnd (string p0, global::Com.Adobe.Mobile.Analytics.ITimedActionBlock p1)
		{
			if (id_trackTimedActionEnd_Ljava_lang_String_Lcom_adobe_mobile_Analytics_TimedActionBlock_ == IntPtr.Zero)
				id_trackTimedActionEnd_Ljava_lang_String_Lcom_adobe_mobile_Analytics_TimedActionBlock_ = JNIEnv.GetStaticMethodID (class_ref, "trackTimedActionEnd", "(Ljava/lang/String;Lcom/adobe/mobile/Analytics$TimedActionBlock;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_trackTimedActionEnd_Ljava_lang_String_Lcom_adobe_mobile_Analytics_TimedActionBlock_, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_trackTimedActionStart_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Analytics']/method[@name='trackTimedActionStart' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map']]"
		[Register ("trackTimedActionStart", "(Ljava/lang/String;Ljava/util/Map;)V", "")]
		public static void TrackTimedActionStart (string p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1)
		{
			if (id_trackTimedActionStart_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_trackTimedActionStart_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "trackTimedActionStart", "(Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_trackTimedActionStart_Ljava_lang_String_Ljava_util_Map_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_trackTimedActionUpdate_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Analytics']/method[@name='trackTimedActionUpdate' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map']]"
		[Register ("trackTimedActionUpdate", "(Ljava/lang/String;Ljava/util/Map;)V", "")]
		public static void TrackTimedActionUpdate (string p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1)
		{
			if (id_trackTimedActionUpdate_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_trackTimedActionUpdate_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "trackTimedActionUpdate", "(Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p1);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_trackTimedActionUpdate_Ljava_lang_String_Ljava_util_Map_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_trackingTimedActionExists_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.adobe.mobile']/class[@name='Analytics']/method[@name='trackingTimedActionExists' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("trackingTimedActionExists", "(Ljava/lang/String;)Z", "")]
		public static bool TrackingTimedActionExists (string p0)
		{
			if (id_trackingTimedActionExists_Ljava_lang_String_ == IntPtr.Zero)
				id_trackingTimedActionExists_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "trackingTimedActionExists", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_trackingTimedActionExists_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
