//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_Object_RENDERGLOBAL : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_Object_RENDERGLOBAL(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_Object_RENDERGLOBAL obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_Object_RENDERGLOBAL() {
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
          LibreDWGPINVOKE.delete_Dwg_Object_RENDERGLOBAL(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_Object_Object parent {
    set {
      LibreDWGPINVOKE.Dwg_Object_RENDERGLOBAL_parent_set(swigCPtr, Dwg_Object_Object.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_RENDERGLOBAL_parent_get(swigCPtr);
      Dwg_Object_Object ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Object(cPtr, false);
      return ret;
    } 
  }

  public uint class_version {
    set {
      LibreDWGPINVOKE.Dwg_Object_RENDERGLOBAL_class_version_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_RENDERGLOBAL_class_version_get(swigCPtr);
      return ret;
    } 
  }

  public uint procedure {
    set {
      LibreDWGPINVOKE.Dwg_Object_RENDERGLOBAL_procedure_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_RENDERGLOBAL_procedure_get(swigCPtr);
      return ret;
    } 
  }

  public uint destination {
    set {
      LibreDWGPINVOKE.Dwg_Object_RENDERGLOBAL_destination_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_RENDERGLOBAL_destination_get(swigCPtr);
      return ret;
    } 
  }

  public byte save_enabled {
    set {
      LibreDWGPINVOKE.Dwg_Object_RENDERGLOBAL_save_enabled_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_RENDERGLOBAL_save_enabled_get(swigCPtr);
      return ret;
    } 
  }

  public string save_filename {
    set {
      LibreDWGPINVOKE.Dwg_Object_RENDERGLOBAL_save_filename_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_Object_RENDERGLOBAL_save_filename_get(swigCPtr);
      return ret;
    } 
  }

  public uint image_width {
    set {
      LibreDWGPINVOKE.Dwg_Object_RENDERGLOBAL_image_width_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_RENDERGLOBAL_image_width_get(swigCPtr);
      return ret;
    } 
  }

  public uint image_height {
    set {
      LibreDWGPINVOKE.Dwg_Object_RENDERGLOBAL_image_height_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_RENDERGLOBAL_image_height_get(swigCPtr);
      return ret;
    } 
  }

  public byte predef_presets_first {
    set {
      LibreDWGPINVOKE.Dwg_Object_RENDERGLOBAL_predef_presets_first_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_RENDERGLOBAL_predef_presets_first_get(swigCPtr);
      return ret;
    } 
  }

  public byte highlevel_info {
    set {
      LibreDWGPINVOKE.Dwg_Object_RENDERGLOBAL_highlevel_info_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_RENDERGLOBAL_highlevel_info_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Object_RENDERGLOBAL() : this(LibreDWGPINVOKE.new_Dwg_Object_RENDERGLOBAL(), true) {
  }

}
