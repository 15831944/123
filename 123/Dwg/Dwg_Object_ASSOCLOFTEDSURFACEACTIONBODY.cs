//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY() {
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
          LibreDWGPINVOKE.delete_Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_Object_Object parent {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY_parent_set(swigCPtr, Dwg_Object_Object.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY_parent_get(swigCPtr);
      Dwg_Object_Object ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Object(cPtr, false);
      return ret;
    } 
  }

  public uint aab_version {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY_aab_version_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY_aab_version_get(swigCPtr);
      return ret;
    } 
  }

  public uint pab_status {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY_pab_status_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY_pab_status_get(swigCPtr);
      return ret;
    } 
  }

  public uint pab_l2 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY_pab_l2_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY_pab_l2_get(swigCPtr);
      return ret;
    } 
  }

  public uint num_deps {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY_num_deps_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY_num_deps_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_p__dwg_object_ref writedeps {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY_writedeps_set(swigCPtr, SWIGTYPE_p_p__dwg_object_ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY_writedeps_get(swigCPtr);
      SWIGTYPE_p_p__dwg_object_ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p__dwg_object_ref(cPtr, false);
      return ret;
    } 
  }

  public uint pab_l4 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY_pab_l4_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY_pab_l4_get(swigCPtr);
      return ret;
    } 
  }

  public uint pab_l5 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY_pab_l5_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY_pab_l5_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_p__dwg_object_ref readdeps {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY_readdeps_set(swigCPtr, SWIGTYPE_p_p__dwg_object_ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY_readdeps_get(swigCPtr);
      SWIGTYPE_p_p__dwg_object_ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p__dwg_object_ref(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_p_char descriptions {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY_descriptions_set(swigCPtr, SWIGTYPE_p_p_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY_descriptions_get(swigCPtr);
      SWIGTYPE_p_p_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_char(cPtr, false);
      return ret;
    } 
  }

  public uint sab_status {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY_sab_status_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY_sab_status_get(swigCPtr);
      return ret;
    } 
  }

  public byte sab_b1 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY_sab_b1_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY_sab_b1_get(swigCPtr);
      return ret;
    } 
  }

  public uint sab_l2 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY_sab_l2_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY_sab_l2_get(swigCPtr);
      return ret;
    } 
  }

  public byte sab_b2 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY_sab_b2_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY_sab_b2_get(swigCPtr);
      return ret;
    } 
  }

  public ushort sab_s1 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY_sab_s1_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY_sab_s1_get(swigCPtr);
      return ret;
    } 
  }

  public uint pbsab_status {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY_pbsab_status_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY_pbsab_status_get(swigCPtr);
      return ret;
    } 
  }

  public uint lsab_status {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY_lsab_status_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY_lsab_status_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY() : this(LibreDWGPINVOKE.new_Dwg_Object_ASSOCLOFTEDSURFACEACTIONBODY(), true) {
  }

}
