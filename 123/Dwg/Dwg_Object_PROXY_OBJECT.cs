//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_Object_PROXY_OBJECT : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_Object_PROXY_OBJECT(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_Object_PROXY_OBJECT obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_Object_PROXY_OBJECT() {
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
          LibreDWGPINVOKE.delete_Dwg_Object_PROXY_OBJECT(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_Object_Object parent {
    set {
      LibreDWGPINVOKE.Dwg_Object_PROXY_OBJECT_parent_set(swigCPtr, Dwg_Object_Object.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_PROXY_OBJECT_parent_get(swigCPtr);
      Dwg_Object_Object ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Object(cPtr, false);
      return ret;
    } 
  }

  public uint class_id {
    set {
      LibreDWGPINVOKE.Dwg_Object_PROXY_OBJECT_class_id_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_PROXY_OBJECT_class_id_get(swigCPtr);
      return ret;
    } 
  }

  public uint version {
    set {
      LibreDWGPINVOKE.Dwg_Object_PROXY_OBJECT_version_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_PROXY_OBJECT_version_get(swigCPtr);
      return ret;
    } 
  }

  public uint maint_version {
    set {
      LibreDWGPINVOKE.Dwg_Object_PROXY_OBJECT_maint_version_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_PROXY_OBJECT_maint_version_get(swigCPtr);
      return ret;
    } 
  }

  public byte from_dxf {
    set {
      LibreDWGPINVOKE.Dwg_Object_PROXY_OBJECT_from_dxf_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_PROXY_OBJECT_from_dxf_get(swigCPtr);
      return ret;
    } 
  }

  public uint data_numbits {
    set {
      LibreDWGPINVOKE.Dwg_Object_PROXY_OBJECT_data_numbits_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_PROXY_OBJECT_data_numbits_get(swigCPtr);
      return ret;
    } 
  }

  public uint data_size {
    set {
      LibreDWGPINVOKE.Dwg_Object_PROXY_OBJECT_data_size_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_PROXY_OBJECT_data_size_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_char data {
    set {
      LibreDWGPINVOKE.Dwg_Object_PROXY_OBJECT_data_set(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_PROXY_OBJECT_data_get(swigCPtr);
      SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
      return ret;
    } 
  }

  public uint num_objids {
    set {
      LibreDWGPINVOKE.Dwg_Object_PROXY_OBJECT_num_objids_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_PROXY_OBJECT_num_objids_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_p__dwg_object_ref objids {
    set {
      LibreDWGPINVOKE.Dwg_Object_PROXY_OBJECT_objids_set(swigCPtr, SWIGTYPE_p_p__dwg_object_ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_PROXY_OBJECT_objids_get(swigCPtr);
      SWIGTYPE_p_p__dwg_object_ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p__dwg_object_ref(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Object_PROXY_OBJECT() : this(LibreDWGPINVOKE.new_Dwg_Object_PROXY_OBJECT(), true) {
  }

}
