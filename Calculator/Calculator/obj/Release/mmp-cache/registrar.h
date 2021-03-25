#pragma clang diagnostic ignored "-Wdeprecated-declarations"
#pragma clang diagnostic ignored "-Wtypedef-redefinition"
#pragma clang diagnostic ignored "-Wobjc-designated-initializers"
#pragma clang diagnostic ignored "-Wunguarded-availability-new"
#include <stdarg.h>
#include <objc/objc.h>
#include <objc/runtime.h>
#include <objc/message.h>
#import <Foundation/Foundation.h>
#import <QuartzCore/QuartzCore.h>
#import <AppKit/AppKit.h>

@class __monomac_internal_ActionDispatcher;
@class NSApplicationDelegate;
@class Foundation_NSDispatcher;
@class __MonoMac_NSSynchronizationContextDispatcher;
@class Foundation_NSAsyncDispatcher;
@class __MonoMac_NSAsyncSynchronizationContextDispatcher;
@class __NSGestureRecognizerToken;
@class __NSGestureRecognizerParameterlessToken;
@class __NSGestureRecognizerParametrizedToken;
@class __NSClickGestureRecognizer;
@class __NSMagnificationGestureRecognizer;
@class __NSPanGestureRecognizer;
@class __NSPressGestureRecognizer;
@class __NSRotationGestureRecognizer;
@class __NSObject_Disposer;
@class ViewController;
@class MainWindow;
@class AppDelegate;

@interface NSApplicationDelegate : NSObject<NSApplicationDelegate> {
}
	-(id) init;
@end

@interface __NSGestureRecognizerToken : NSObject {
}
	-(void) release;
	-(id) retain;
	-(uint32_t) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (uint32_t) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface __NSGestureRecognizerParameterlessToken : __NSGestureRecognizerToken {
}
	-(void) target;
@end

@interface __NSGestureRecognizerParametrizedToken : __NSGestureRecognizerToken {
}
	-(void) target:(NSGestureRecognizer *)p0;
@end

@interface ViewController : NSViewController {
}
	@property (nonatomic, assign) NSTextField * ResultsField;
	-(void) release;
	-(id) retain;
	-(uint32_t) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (uint32_t) gchandle;
	-(NSTextField *) ResultsField;
	-(void) setResultsField:(NSTextField *)p0;
	-(void) viewDidLoad;
	-(NSObject *) representedObject;
	-(void) setRepresentedObject:(NSObject *)p0;
	-(void) _0:(NSObject *)p0;
	-(void) _1:(NSObject *)p0;
	-(void) _2:(NSObject *)p0;
	-(void) _3:(NSObject *)p0;
	-(void) _4:(NSObject *)p0;
	-(void) _5:(NSObject *)p0;
	-(void) _6:(NSObject *)p0;
	-(void) _7:(NSObject *)p0;
	-(void) _8:(NSObject *)p0;
	-(void) _9:(NSObject *)p0;
	-(void) clear:(NSObject *)p0;
	-(void) coma:(NSObject *)p0;
	-(void) divide:(NSObject *)p0;
	-(void) equals:(NSObject *)p0;
	-(void) minus:(NSObject *)p0;
	-(void) multiply:(NSObject *)p0;
	-(void) plus:(NSObject *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface MainWindow : NSWindowController {
}
	-(void) release;
	-(id) retain;
	-(uint32_t) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (uint32_t) gchandle;
	-(void) windowDidLoad;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface AppDelegate : NSObject<NSApplicationDelegate, NSApplicationDelegate> {
}
	-(void) release;
	-(id) retain;
	-(uint32_t) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (uint32_t) gchandle;
	-(void) applicationDidFinishLaunching:(NSNotification *)p0;
	-(void) applicationWillTerminate:(NSNotification *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end


