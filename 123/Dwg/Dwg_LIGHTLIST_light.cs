//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_LIGHTLIST_light : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_LIGHTLIST_light(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_LIGHTLIST_light obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_LIGHTLIST_light() {
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
          LibreDWGPINVOKE.delete_Dwg_LIGHTLIST_light(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_Object_LIGHTLIST parent {
    set {
      LibreDWGPINVOKE.Dwg_LIGHTLIST_light_parent_set(swigCPtr, Dwg_Object_LIGHTLIST.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_LIGHTLIST_light_parent_get(swigCPtr);
      Dwg_Object_LIGHTLIST ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_LIGHTLIST(cPtr, false);
      return ret;
    } 
  }

  public string name {
    set {
      LibreDWGPINVOKE.Dwg_LIGHTLIST_light_name_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_LIGHTLIST_light_name_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Object_Ref handle {
    set {
      LibreDWGPINVOKE.Dwg_LIGHTLIST_light_handle_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_LIGHTLIST_light_handle_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public Dwg_LIGHTLIST_light() : this(LibreDWGPINVOKE.new_Dwg_LIGHTLIST_light(), true) {
  }

}
