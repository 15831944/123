//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_Object_RENDERENVIRONMENT : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_Object_RENDERENVIRONMENT(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_Object_RENDERENVIRONMENT obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_Object_RENDERENVIRONMENT() {
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
          LibreDWGPINVOKE.delete_Dwg_Object_RENDERENVIRONMENT(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_Object_Object parent {
    set {
      LibreDWGPINVOKE.Dwg_Object_RENDERENVIRONMENT_parent_set(swigCPtr, Dwg_Object_Object.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_RENDERENVIRONMENT_parent_get(swigCPtr);
      Dwg_Object_Object ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Object(cPtr, false);
      return ret;
    } 
  }

  public uint class_version {
    set {
      LibreDWGPINVOKE.Dwg_Object_RENDERENVIRONMENT_class_version_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_RENDERENVIRONMENT_class_version_get(swigCPtr);
      return ret;
    } 
  }

  public byte fog_enabled {
    set {
      LibreDWGPINVOKE.Dwg_Object_RENDERENVIRONMENT_fog_enabled_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_RENDERENVIRONMENT_fog_enabled_get(swigCPtr);
      return ret;
    } 
  }

  public byte fog_background_enabled {
    set {
      LibreDWGPINVOKE.Dwg_Object_RENDERENVIRONMENT_fog_background_enabled_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_RENDERENVIRONMENT_fog_background_enabled_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Color fog_color {
    set {
      LibreDWGPINVOKE.Dwg_Object_RENDERENVIRONMENT_fog_color_set(swigCPtr, Dwg_Color.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_RENDERENVIRONMENT_fog_color_get(swigCPtr);
      Dwg_Color ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Color(cPtr, false);
      return ret;
    } 
  }

  public double fog_density_near {
    set {
      LibreDWGPINVOKE.Dwg_Object_RENDERENVIRONMENT_fog_density_near_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_RENDERENVIRONMENT_fog_density_near_get(swigCPtr);
      return ret;
    } 
  }

  public double fog_density_far {
    set {
      LibreDWGPINVOKE.Dwg_Object_RENDERENVIRONMENT_fog_density_far_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_RENDERENVIRONMENT_fog_density_far_get(swigCPtr);
      return ret;
    } 
  }

  public double fog_distance_near {
    set {
      LibreDWGPINVOKE.Dwg_Object_RENDERENVIRONMENT_fog_distance_near_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_RENDERENVIRONMENT_fog_distance_near_get(swigCPtr);
      return ret;
    } 
  }

  public double fog_distance_far {
    set {
      LibreDWGPINVOKE.Dwg_Object_RENDERENVIRONMENT_fog_distance_far_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_RENDERENVIRONMENT_fog_distance_far_get(swigCPtr);
      return ret;
    } 
  }

  public byte environ_image_enabled {
    set {
      LibreDWGPINVOKE.Dwg_Object_RENDERENVIRONMENT_environ_image_enabled_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_RENDERENVIRONMENT_environ_image_enabled_get(swigCPtr);
      return ret;
    } 
  }

  public string environ_image_filename {
    set {
      LibreDWGPINVOKE.Dwg_Object_RENDERENVIRONMENT_environ_image_filename_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_Object_RENDERENVIRONMENT_environ_image_filename_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Object_RENDERENVIRONMENT() : this(LibreDWGPINVOKE.new_Dwg_Object_RENDERENVIRONMENT(), true) {
  }

}
