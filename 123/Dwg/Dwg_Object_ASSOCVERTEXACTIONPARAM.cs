//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_Object_ASSOCVERTEXACTIONPARAM : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_Object_ASSOCVERTEXACTIONPARAM(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_Object_ASSOCVERTEXACTIONPARAM obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_Object_ASSOCVERTEXACTIONPARAM() {
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
          LibreDWGPINVOKE.delete_Dwg_Object_ASSOCVERTEXACTIONPARAM(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_Object_Object parent {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCVERTEXACTIONPARAM_parent_set(swigCPtr, Dwg_Object_Object.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_ASSOCVERTEXACTIONPARAM_parent_get(swigCPtr);
      Dwg_Object_Object ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Object(cPtr, false);
      return ret;
    } 
  }

  public ushort class_version {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCVERTEXACTIONPARAM_class_version_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_ASSOCVERTEXACTIONPARAM_class_version_get(swigCPtr);
      return ret;
    } 
  }

  public byte unknown {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCVERTEXACTIONPARAM_unknown_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_ASSOCVERTEXACTIONPARAM_unknown_get(swigCPtr);
      return ret;
    } 
  }

  public byte unknown1 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCVERTEXACTIONPARAM_unknown1_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_ASSOCVERTEXACTIONPARAM_unknown1_get(swigCPtr);
      return ret;
    } 
  }

  public ushort status {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCVERTEXACTIONPARAM_status_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_ASSOCVERTEXACTIONPARAM_status_get(swigCPtr);
      return ret;
    } 
  }

  public string name {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCVERTEXACTIONPARAM_name_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_Object_ASSOCVERTEXACTIONPARAM_name_get(swigCPtr);
      return ret;
    } 
  }

  public ushort flags {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCVERTEXACTIONPARAM_flags_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_ASSOCVERTEXACTIONPARAM_flags_get(swigCPtr);
      return ret;
    } 
  }

  public double unknown3 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCVERTEXACTIONPARAM_unknown3_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_ASSOCVERTEXACTIONPARAM_unknown3_get(swigCPtr);
      return ret;
    } 
  }

  public ushort num_actions {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCVERTEXACTIONPARAM_num_actions_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_ASSOCVERTEXACTIONPARAM_num_actions_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_p__dwg_object_ref actions {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCVERTEXACTIONPARAM_actions_set(swigCPtr, SWIGTYPE_p_p__dwg_object_ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_ASSOCVERTEXACTIONPARAM_actions_get(swigCPtr);
      SWIGTYPE_p_p__dwg_object_ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p__dwg_object_ref(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Object_Ref writedep {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCVERTEXACTIONPARAM_writedep_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_ASSOCVERTEXACTIONPARAM_writedep_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Object_ASSOCVERTEXACTIONPARAM() : this(LibreDWGPINVOKE.new_Dwg_Object_ASSOCVERTEXACTIONPARAM(), true) {
  }

}
