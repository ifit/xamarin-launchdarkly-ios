using System;
using Foundation;
using LaunchDarkly;
using ObjCRuntime;

namespace Binding
{
	// @interface LDInvalidArgumentError : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC12LaunchDarkly22LDInvalidArgumentError")]
	[DisableDefaultCtor]
	interface LDInvalidArgumentError
	{
	}

	// @interface LDChangedFlag : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface LDChangedFlag
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull key;
		[Export ("key")]
		string Key { get; }
	}

	// @interface LDArrayChangedFlag : LDChangedFlag
	[BaseType (typeof(LDChangedFlag))]
	interface LDArrayChangedFlag
	{
		// @property (readonly, copy, nonatomic) NSArray * _Nullable oldValue;
		[NullAllowed, Export ("oldValue", ArgumentSemantic.Copy)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] OldValue { get; }

		// @property (readonly, copy, nonatomic) NSArray * _Nullable newValue;
		[NullAllowed, Export ("newValue", ArgumentSemantic.Copy)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] NewValue { get; }

		// @property (readonly, nonatomic) BOOL typeMismatch;
		[Export ("typeMismatch")]
		bool TypeMismatch { get; }
	}

	// @interface ArrayEvaluationDetail : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface ArrayEvaluationDetail
	{
		// @property (readonly, copy, nonatomic) NSArray * _Nullable value;
		[NullAllowed, Export ("value", ArgumentSemantic.Copy)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] Value { get; }

		// @property (readonly, nonatomic) NSInteger variationIndex;
		[Export ("variationIndex")]
		nint VariationIndex { get; }

		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nullable reason;
		[NullAllowed, Export ("reason", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> Reason { get; }
	}

	// @interface LDBoolChangedFlag : LDChangedFlag
	[BaseType (typeof(LDChangedFlag))]
	interface LDBoolChangedFlag
	{
		// @property (readonly, nonatomic) BOOL oldValue;
		[Export ("oldValue")]
		bool OldValue { get; }

		// @property (readonly, nonatomic) BOOL newValue;
		[Export ("newValue")]
		bool NewValue { get; }

		// @property (readonly, nonatomic) BOOL typeMismatch;
		[Export ("typeMismatch")]
		bool TypeMismatch { get; }
	}

	// @interface LDBoolEvaluationDetail : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface LDBoolEvaluationDetail
	{
		// @property (readonly, nonatomic) BOOL value;
		[Export ("value")]
		bool Value { get; }

		// @property (readonly, nonatomic) NSInteger variationIndex;
		[Export ("variationIndex")]
		nint VariationIndex { get; }

		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nullable reason;
		[NullAllowed, Export ("reason", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> Reason { get; }
	}

	// @interface LDClient : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface LDClient
	{
		// @property (readonly, nonatomic) BOOL isOnline;
		[Export ("isOnline")]
		bool IsOnline { get; }

		// -(void)setOnline:(BOOL)goOnline;
		[Export ("setOnline:")]
		void SetOnline (bool goOnline);

		// -(void)setOnline:(BOOL)goOnline completion:(void (^ _Nullable)(void))completion;
		[Export ("setOnline:completion:")]
		void SetOnline (bool goOnline, [NullAllowed] Action completion);

		// -(void)identifyWithUser:(LDUser * _Nonnull)user;
		[Export ("identifyWithUser:")]
		void IdentifyWithUser (LDUser user);

		// -(void)identifyWithUser:(LDUser * _Nonnull)user completion:(void (^ _Nullable)(void))completion;
		[Export ("identifyWithUser:completion:")]
		void IdentifyWithUser (LDUser user, [NullAllowed] Action completion);

		// -(void)close;
		[Export ("close")]
		void Close ();

		// +(LDClient * _Nullable)get __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("get")]
		[Verify (MethodToProperty)]
		LDClient Get { get; }

		// +(LDClient * _Nullable)getWithEnvironment:(NSString * _Nonnull)environment __attribute__((warn_unused_result("")));
		[Static]
		[Export ("getWithEnvironment:")]
		[return: NullAllowed]
		LDClient GetWithEnvironment (string environment);

		// -(BOOL)boolVariationForKey:(NSString * _Nonnull)key defaultValue:(BOOL)defaultValue __attribute__((warn_unused_result("")));
		[Export ("boolVariationForKey:defaultValue:")]
		bool BoolVariationForKey (string key, bool defaultValue);

		// -(LDBoolEvaluationDetail * _Nonnull)boolVariationDetailForKey:(NSString * _Nonnull)key defaultValue:(BOOL)defaultValue __attribute__((warn_unused_result("")));
		[Export ("boolVariationDetailForKey:defaultValue:")]
		LDBoolEvaluationDetail BoolVariationDetailForKey (string key, bool defaultValue);

		// -(NSInteger)integerVariationForKey:(NSString * _Nonnull)key defaultValue:(NSInteger)defaultValue __attribute__((warn_unused_result("")));
		[Export ("integerVariationForKey:defaultValue:")]
		nint IntegerVariationForKey (string key, nint defaultValue);

		// -(LDIntegerEvaluationDetail * _Nonnull)integerVariationDetailForKey:(NSString * _Nonnull)key defaultValue:(NSInteger)defaultValue __attribute__((warn_unused_result("")));
		[Export ("integerVariationDetailForKey:defaultValue:")]
		LDIntegerEvaluationDetail IntegerVariationDetailForKey (string key, nint defaultValue);

		// -(double)doubleVariationForKey:(NSString * _Nonnull)key defaultValue:(double)defaultValue __attribute__((warn_unused_result("")));
		[Export ("doubleVariationForKey:defaultValue:")]
		double DoubleVariationForKey (string key, double defaultValue);

		// -(LDDoubleEvaluationDetail * _Nonnull)doubleVariationDetailForKey:(NSString * _Nonnull)key defaultValue:(double)defaultValue __attribute__((warn_unused_result("")));
		[Export ("doubleVariationDetailForKey:defaultValue:")]
		LDDoubleEvaluationDetail DoubleVariationDetailForKey (string key, double defaultValue);

		// -(NSString * _Nullable)stringVariationForKey:(NSString * _Nonnull)key defaultValue:(NSString * _Nullable)defaultValue __attribute__((warn_unused_result("")));
		[Export ("stringVariationForKey:defaultValue:")]
		[return: NullAllowed]
		string StringVariationForKey (string key, [NullAllowed] string defaultValue);

		// -(LDStringEvaluationDetail * _Nonnull)stringVariationDetailForKey:(NSString * _Nonnull)key defaultValue:(NSString * _Nullable)defaultValue __attribute__((warn_unused_result("")));
		[Export ("stringVariationDetailForKey:defaultValue:")]
		LDStringEvaluationDetail StringVariationDetailForKey (string key, [NullAllowed] string defaultValue);

		// -(NSArray * _Nullable)arrayVariationForKey:(NSString * _Nonnull)key defaultValue:(NSArray * _Nullable)defaultValue __attribute__((warn_unused_result("")));
		[Export ("arrayVariationForKey:defaultValue:")]
		[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		[return: NullAllowed]
		NSObject[] ArrayVariationForKey (string key, [NullAllowed] NSObject[] defaultValue);

		// -(ArrayEvaluationDetail * _Nonnull)arrayVariationDetailForKey:(NSString * _Nonnull)key defaultValue:(NSArray * _Nullable)defaultValue __attribute__((warn_unused_result("")));
		[Export ("arrayVariationDetailForKey:defaultValue:")]
		[Verify (StronglyTypedNSArray)]
		ArrayEvaluationDetail ArrayVariationDetailForKey (string key, [NullAllowed] NSObject[] defaultValue);

		// -(NSDictionary<NSString *,id> * _Nullable)dictionaryVariationForKey:(NSString * _Nonnull)key defaultValue:(NSDictionary<NSString *,id> * _Nullable)defaultValue __attribute__((warn_unused_result("")));
		[Export ("dictionaryVariationForKey:defaultValue:")]
		[return: NullAllowed]
		NSDictionary<NSString, NSObject> DictionaryVariationForKey (string key, [NullAllowed] NSDictionary<NSString, NSObject> defaultValue);

		// -(DictionaryEvaluationDetail * _Nonnull)dictionaryVariationDetailForKey:(NSString * _Nonnull)key defaultValue:(NSDictionary<NSString *,id> * _Nullable)defaultValue __attribute__((warn_unused_result("")));
		[Export ("dictionaryVariationDetailForKey:defaultValue:")]
		DictionaryEvaluationDetail DictionaryVariationDetailForKey (string key, [NullAllowed] NSDictionary<NSString, NSObject> defaultValue);

		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nullable allFlags;
		[NullAllowed, Export ("allFlags", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> AllFlags { get; }

		// -(void)observeBool:(NSString * _Nonnull)key owner:(id _Nonnull)owner handler:(void (^ _Nonnull)(LDBoolChangedFlag * _Nonnull))handler;
		[Export ("observeBool:owner:handler:")]
		void ObserveBool (string key, NSObject owner, Action<LDBoolChangedFlag> handler);

		// -(void)observeInteger:(NSString * _Nonnull)key owner:(id _Nonnull)owner handler:(void (^ _Nonnull)(LDIntegerChangedFlag * _Nonnull))handler;
		[Export ("observeInteger:owner:handler:")]
		void ObserveInteger (string key, NSObject owner, Action<LDIntegerChangedFlag> handler);

		// -(void)observeDouble:(NSString * _Nonnull)key owner:(id _Nonnull)owner handler:(void (^ _Nonnull)(LDDoubleChangedFlag * _Nonnull))handler;
		[Export ("observeDouble:owner:handler:")]
		void ObserveDouble (string key, NSObject owner, Action<LDDoubleChangedFlag> handler);

		// -(void)observeString:(NSString * _Nonnull)key owner:(id _Nonnull)owner handler:(void (^ _Nonnull)(LDStringChangedFlag * _Nonnull))handler;
		[Export ("observeString:owner:handler:")]
		void ObserveString (string key, NSObject owner, Action<LDStringChangedFlag> handler);

		// -(void)observeArray:(NSString * _Nonnull)key owner:(id _Nonnull)owner handler:(void (^ _Nonnull)(LDArrayChangedFlag * _Nonnull))handler;
		[Export ("observeArray:owner:handler:")]
		void ObserveArray (string key, NSObject owner, Action<LDArrayChangedFlag> handler);

		// -(void)observeDictionary:(NSString * _Nonnull)key owner:(id _Nonnull)owner handler:(void (^ _Nonnull)(LDDictionaryChangedFlag * _Nonnull))handler;
		[Export ("observeDictionary:owner:handler:")]
		void ObserveDictionary (string key, NSObject owner, Action<LDDictionaryChangedFlag> handler);

		// -(void)observeKeys:(NSArray<NSString *> * _Nonnull)keys owner:(id _Nonnull)owner handler:(void (^ _Nonnull)(NSDictionary<NSString *,LDChangedFlag *> * _Nonnull))handler;
		[Export ("observeKeys:owner:handler:")]
		void ObserveKeys (string[] keys, NSObject owner, Action<NSDictionary<NSString, LDChangedFlag>> handler);

		// -(void)observeAllKeysWithOwner:(id _Nonnull)owner handler:(void (^ _Nonnull)(NSDictionary<NSString *,LDChangedFlag *> * _Nonnull))handler;
		[Export ("observeAllKeysWithOwner:handler:")]
		void ObserveAllKeysWithOwner (NSObject owner, Action<NSDictionary<NSString, LDChangedFlag>> handler);

		// -(void)observeFlagsUnchangedWithOwner:(id _Nonnull)owner handler:(void (^ _Nonnull)(void))handler;
		[Export ("observeFlagsUnchangedWithOwner:handler:")]
		void ObserveFlagsUnchangedWithOwner (NSObject owner, Action handler);

		// -(void)stopObservingForOwner:(id _Nonnull)owner;
		[Export ("stopObservingForOwner:")]
		void StopObservingForOwner (NSObject owner);

		// -(void)observeErrorWithOwner:(id _Nonnull)owner handler:(void (^ _Nonnull)(NSError * _Nonnull))handler;
		[Export ("observeErrorWithOwner:handler:")]
		void ObserveErrorWithOwner (NSObject owner, Action<NSError> handler);

		// -(BOOL)trackWithKey:(NSString * _Nonnull)key data:(id _Nullable)data error:(NSError * _Nullable * _Nullable)error;
		[Export ("trackWithKey:data:error:")]
		bool TrackWithKey (string key, [NullAllowed] NSObject data, [NullAllowed] out NSError error);

		// -(BOOL)trackWithKey:(NSString * _Nonnull)key data:(id _Nullable)data metricValue:(double)metricValue error:(NSError * _Nullable * _Nullable)error;
		[Export ("trackWithKey:data:metricValue:error:")]
		bool TrackWithKey (string key, [NullAllowed] NSObject data, double metricValue, [NullAllowed] out NSError error);

		// -(void)flush;
		[Export ("flush")]
		void Flush ();

		// +(void)startWithConfiguration:(LDConfig * _Nonnull)configuration user:(LDUser * _Nonnull)user completion:(void (^ _Nullable)(void))completion;
		[Static]
		[Export ("startWithConfiguration:user:completion:")]
		void StartWithConfiguration (LDConfig configuration, LDUser user, [NullAllowed] Action completion);

		// +(void)startWithConfiguration:(LDConfig * _Nonnull)configuration user:(LDUser * _Nonnull)user startWaitSeconds:(NSTimeInterval)startWaitSeconds completion:(void (^ _Nullable)(BOOL))completion;
		[Static]
		[Export ("startWithConfiguration:user:startWaitSeconds:completion:")]
		void StartWithConfiguration (LDConfig configuration, LDUser user, double startWaitSeconds, [NullAllowed] Action<bool> completion);
	}

	// @interface LDConfig : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface LDConfig
	{
		// @property (copy, nonatomic) NSString * _Nonnull mobileKey;
		[Export ("mobileKey")]
		string MobileKey { get; set; }

		// @property (copy, nonatomic) NSURL * _Nonnull baseUrl;
		[Export ("baseUrl", ArgumentSemantic.Copy)]
		NSUrl BaseUrl { get; set; }

		// @property (copy, nonatomic) NSURL * _Nonnull eventsUrl;
		[Export ("eventsUrl", ArgumentSemantic.Copy)]
		NSUrl EventsUrl { get; set; }

		// @property (copy, nonatomic) NSURL * _Nonnull streamUrl;
		[Export ("streamUrl", ArgumentSemantic.Copy)]
		NSUrl StreamUrl { get; set; }

		// @property (nonatomic) NSInteger eventCapacity;
		[Export ("eventCapacity")]
		nint EventCapacity { get; set; }

		// @property (nonatomic) NSTimeInterval connectionTimeout;
		[Export ("connectionTimeout")]
		double ConnectionTimeout { get; set; }

		// @property (nonatomic) NSTimeInterval eventFlushInterval;
		[Export ("eventFlushInterval")]
		double EventFlushInterval { get; set; }

		// @property (nonatomic) NSTimeInterval flagPollingInterval;
		[Export ("flagPollingInterval")]
		double FlagPollingInterval { get; set; }

		// @property (nonatomic) NSTimeInterval backgroundFlagPollingInterval;
		[Export ("backgroundFlagPollingInterval")]
		double BackgroundFlagPollingInterval { get; set; }

		// @property (readonly, nonatomic) NSTimeInterval minFlagPollingInterval;
		[Export ("minFlagPollingInterval")]
		double MinFlagPollingInterval { get; }

		// @property (readonly, nonatomic) NSTimeInterval minBackgroundFlagPollInterval;
		[Export ("minBackgroundFlagPollInterval")]
		double MinBackgroundFlagPollInterval { get; }

		// @property (nonatomic) BOOL streamingMode;
		[Export ("streamingMode")]
		bool StreamingMode { get; set; }

		// @property (nonatomic) BOOL enableBackgroundUpdates;
		[Export ("enableBackgroundUpdates")]
		bool EnableBackgroundUpdates { get; set; }

		// @property (nonatomic) BOOL startOnline;
		[Export ("startOnline")]
		bool StartOnline { get; set; }

		// @property (nonatomic) BOOL allUserAttributesPrivate;
		[Export ("allUserAttributesPrivate")]
		bool AllUserAttributesPrivate { get; set; }

		// @property (copy, nonatomic) NSArray<NSString *> * _Nullable privateUserAttributes;
		[NullAllowed, Export ("privateUserAttributes", ArgumentSemantic.Copy)]
		string[] PrivateUserAttributes { get; set; }

		// @property (nonatomic) BOOL useReport;
		[Export ("useReport")]
		bool UseReport { get; set; }

		// @property (nonatomic) BOOL inlineUserInEvents;
		[Export ("inlineUserInEvents")]
		bool InlineUserInEvents { get; set; }

		// @property (nonatomic) BOOL debugMode;
		[Export ("debugMode")]
		bool DebugMode { get; set; }

		// @property (nonatomic) BOOL evaluationReasons;
		[Export ("evaluationReasons")]
		bool EvaluationReasons { get; set; }

		// @property (nonatomic) NSInteger maxCachedUsers;
		[Export ("maxCachedUsers")]
		nint MaxCachedUsers { get; set; }

		// @property (nonatomic) BOOL diagnosticOptOut;
		[Export ("diagnosticOptOut")]
		bool DiagnosticOptOut { get; set; }

		// @property (nonatomic) NSTimeInterval diagnosticRecordingInterval;
		[Export ("diagnosticRecordingInterval")]
		double DiagnosticRecordingInterval { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable wrapperName;
		[NullAllowed, Export ("wrapperName")]
		string WrapperName { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable wrapperVersion;
		[NullAllowed, Export ("wrapperVersion")]
		string WrapperVersion { get; set; }

		// -(NSDictionary<NSString *,NSString *> * _Nonnull)getSecondaryMobileKeys __attribute__((warn_unused_result("")));
		[Export ("getSecondaryMobileKeys")]
		[Verify (MethodToProperty)]
		NSDictionary<NSString, NSString> SecondaryMobileKeys { get; }

		// -(BOOL)setSecondaryMobileKeys:(NSDictionary<NSString *,NSString *> * _Nonnull)keys error:(NSError * _Nullable * _Nullable)error;
		[Export ("setSecondaryMobileKeys:error:")]
		bool SetSecondaryMobileKeys (NSDictionary<NSString, NSString> keys, [NullAllowed] out NSError error);

		// -(instancetype _Nonnull)initWithMobileKey:(NSString * _Nonnull)mobileKey __attribute__((objc_designated_initializer));
		[Export ("initWithMobileKey:")]
		[DesignatedInitializer]
		IntPtr Constructor (string mobileKey);

		// -(BOOL)isEqualWithObject:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export ("isEqualWithObject:")]
		bool IsEqualWithObject ([NullAllowed] NSObject @object);
	}

	// @interface LDDictionaryChangedFlag : LDChangedFlag
	[BaseType (typeof(LDChangedFlag))]
	interface LDDictionaryChangedFlag
	{
		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nullable oldValue;
		[NullAllowed, Export ("oldValue", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> OldValue { get; }

		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nullable newValue;
		[NullAllowed, Export ("newValue", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> NewValue { get; }

		// @property (readonly, nonatomic) BOOL typeMismatch;
		[Export ("typeMismatch")]
		bool TypeMismatch { get; }
	}

	// @interface DictionaryEvaluationDetail : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface DictionaryEvaluationDetail
	{
		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nullable value;
		[NullAllowed, Export ("value", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> Value { get; }

		// @property (readonly, nonatomic) NSInteger variationIndex;
		[Export ("variationIndex")]
		nint VariationIndex { get; }

		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nullable reason;
		[NullAllowed, Export ("reason", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> Reason { get; }
	}

	// @interface LDDoubleChangedFlag : LDChangedFlag
	[BaseType (typeof(LDChangedFlag))]
	interface LDDoubleChangedFlag
	{
		// @property (readonly, nonatomic) double oldValue;
		[Export ("oldValue")]
		double OldValue { get; }

		// @property (readonly, nonatomic) double newValue;
		[Export ("newValue")]
		double NewValue { get; }

		// @property (readonly, nonatomic) BOOL typeMismatch;
		[Export ("typeMismatch")]
		bool TypeMismatch { get; }
	}

	// @interface LDDoubleEvaluationDetail : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface LDDoubleEvaluationDetail
	{
		// @property (readonly, nonatomic) double value;
		[Export ("value")]
		double Value { get; }

		// @property (readonly, nonatomic) NSInteger variationIndex;
		[Export ("variationIndex")]
		nint VariationIndex { get; }

		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nullable reason;
		[NullAllowed, Export ("reason", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> Reason { get; }
	}

	// @interface LDIntegerChangedFlag : LDChangedFlag
	[BaseType (typeof(LDChangedFlag))]
	interface LDIntegerChangedFlag
	{
		// @property (readonly, nonatomic) NSInteger oldValue;
		[Export ("oldValue")]
		nint OldValue { get; }

		// @property (readonly, nonatomic) NSInteger newValue;
		[Export ("newValue")]
		nint NewValue { get; }

		// @property (readonly, nonatomic) BOOL typeMismatch;
		[Export ("typeMismatch")]
		bool TypeMismatch { get; }
	}

	// @interface LDIntegerEvaluationDetail : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface LDIntegerEvaluationDetail
	{
		// @property (readonly, nonatomic) NSInteger value;
		[Export ("value")]
		nint Value { get; }

		// @property (readonly, nonatomic) NSInteger variationIndex;
		[Export ("variationIndex")]
		nint VariationIndex { get; }

		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nullable reason;
		[NullAllowed, Export ("reason", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> Reason { get; }
	}

	// @interface LDStringChangedFlag : LDChangedFlag
	[BaseType (typeof(LDChangedFlag))]
	interface LDStringChangedFlag
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable oldValue;
		[NullAllowed, Export ("oldValue")]
		string OldValue { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable newValue;
		[NullAllowed, Export ("newValue")]
		string NewValue { get; }

		// @property (readonly, nonatomic) BOOL typeMismatch;
		[Export ("typeMismatch")]
		bool TypeMismatch { get; }
	}

	// @interface LDStringEvaluationDetail : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface LDStringEvaluationDetail
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable value;
		[NullAllowed, Export ("value")]
		string Value { get; }

		// @property (readonly, nonatomic) NSInteger variationIndex;
		[Export ("variationIndex")]
		nint VariationIndex { get; }

		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nullable reason;
		[NullAllowed, Export ("reason", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> Reason { get; }
	}

	// @interface LDUser : NSObject
	[BaseType (typeof(NSObject))]
	interface LDUser
	{
		// @property (readonly, copy, nonatomic, class) NSArray<NSString *> * _Nonnull privatizableAttributes;
		[Static]
		[Export ("privatizableAttributes", ArgumentSemantic.Copy)]
		string[] PrivatizableAttributes { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull attributeSecondary;
		[Static]
		[Export ("attributeSecondary")]
		string AttributeSecondary { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull attributeName;
		[Static]
		[Export ("attributeName")]
		string AttributeName { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull attributeFirstName;
		[Static]
		[Export ("attributeFirstName")]
		string AttributeFirstName { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull attributeLastName;
		[Static]
		[Export ("attributeLastName")]
		string AttributeLastName { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull attributeCountry;
		[Static]
		[Export ("attributeCountry")]
		string AttributeCountry { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull attributeIPAddress;
		[Static]
		[Export ("attributeIPAddress")]
		string AttributeIPAddress { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull attributeEmail;
		[Static]
		[Export ("attributeEmail")]
		string AttributeEmail { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull attributeAvatar;
		[Static]
		[Export ("attributeAvatar")]
		string AttributeAvatar { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull attributeCustom;
		[Static]
		[Export ("attributeCustom")]
		string AttributeCustom { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull key;
		[Export ("key")]
		string Key { get; }

		// @property (copy, nonatomic) NSString * _Nullable secondary;
		[NullAllowed, Export ("secondary")]
		string Secondary { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable name;
		[NullAllowed, Export ("name")]
		string Name { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable firstName;
		[NullAllowed, Export ("firstName")]
		string FirstName { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable lastName;
		[NullAllowed, Export ("lastName")]
		string LastName { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable country;
		[NullAllowed, Export ("country")]
		string Country { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable ipAddress;
		[NullAllowed, Export ("ipAddress")]
		string IpAddress { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable email;
		[NullAllowed, Export ("email")]
		string Email { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable avatar;
		[NullAllowed, Export ("avatar")]
		string Avatar { get; set; }

		// @property (copy, nonatomic) NSDictionary<NSString *,id> * _Nullable custom;
		[NullAllowed, Export ("custom", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> Custom { get; set; }

		// @property (nonatomic) BOOL isAnonymous;
		[Export ("isAnonymous")]
		bool IsAnonymous { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable device;
		[NullAllowed, Export ("device")]
		string Device { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable operatingSystem;
		[NullAllowed, Export ("operatingSystem")]
		string OperatingSystem { get; set; }

		// @property (copy, nonatomic) NSArray<NSString *> * _Nullable privateAttributes;
		[NullAllowed, Export ("privateAttributes", ArgumentSemantic.Copy)]
		string[] PrivateAttributes { get; set; }

		// -(instancetype _Nonnull)initWithKey:(NSString * _Nonnull)key __attribute__((objc_designated_initializer));
		[Export ("initWithKey:")]
		[DesignatedInitializer]
		IntPtr Constructor (string key);

		// -(instancetype _Nonnull)initWithUserDictionary:(NSDictionary<NSString *,id> * _Nonnull)userDictionary __attribute__((objc_designated_initializer));
		[Export ("initWithUserDictionary:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSDictionary<NSString, NSObject> userDictionary);

		// -(BOOL)isEqualWithObject:(id _Nonnull)object __attribute__((warn_unused_result("")));
		[Export ("isEqualWithObject:")]
		bool IsEqualWithObject (NSObject @object);
	}
}
