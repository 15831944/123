//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_Object_Ref : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_Object_Ref(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_Object_Ref obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_Object_Ref() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LibreDWGPINVOKE.delete_Dwg_Object_Ref(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_Object obj {
    set {
      LibreDWGPINVOKE.Dwg_Object_Ref_obj_set(swigCPtr, Dwg_Object.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_Ref_obj_get(swigCPtr);
      Dwg_Object ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Handle handleref {
    set {
      LibreDWGPINVOKE.Dwg_Object_Ref_handleref_set(swigCPtr, Dwg_Handle.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_Ref_handleref_get(swigCPtr);
      Dwg_Handle ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Handle(cPtr, false);
      return ret;
    } 
  }

  public uint absolute_ref {
    set {
      LibreDWGPINVOKE.Dwg_Object_Ref_absolute_ref_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_Ref_absolute_ref_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Object_Ref() : this(LibreDWGPINVOKE.new_Dwg_Object_Ref(), true) {
  }

}
