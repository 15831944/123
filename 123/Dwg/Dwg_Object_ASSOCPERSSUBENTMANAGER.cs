//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_Object_ASSOCPERSSUBENTMANAGER : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_Object_ASSOCPERSSUBENTMANAGER(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_Object_ASSOCPERSSUBENTMANAGER obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_Object_ASSOCPERSSUBENTMANAGER() {
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
          LibreDWGPINVOKE.delete_Dwg_Object_ASSOCPERSSUBENTMANAGER(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_Object_Object parent {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_parent_set(swigCPtr, Dwg_Object_Object.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_parent_get(swigCPtr);
      Dwg_Object_Object ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Object(cPtr, false);
      return ret;
    } 
  }

  public uint class_version {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_class_version_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_class_version_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl1 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl1_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl1_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl2 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl2_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl2_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl3 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl3_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl3_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl4 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl4_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl4_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl5 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl5_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl5_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl6 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl6_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl6_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl6a {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl6a_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl6a_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl7a {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl7a_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl7a_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl7 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl7_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl7_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl8 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl8_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl8_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl9 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl9_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl9_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl10 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl10_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl10_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl11 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl11_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl11_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl12 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl12_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl12_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl13 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl13_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl13_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl14 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl14_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl14_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl15 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl15_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl15_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl16 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl16_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl16_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl17 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl17_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl17_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl18 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl18_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl18_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl19 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl19_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl19_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl20 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl20_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl20_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl21 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl21_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl21_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl22 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl22_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl22_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl23 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl23_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl23_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl24 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl24_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl24_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl25 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl25_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl25_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl26 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl26_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl26_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl27 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl27_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl27_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl28 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl28_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl28_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl29 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl29_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl29_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl30 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl30_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl30_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl31 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl31_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl31_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl32 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl32_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl32_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl33 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl33_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl33_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl34 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl34_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl34_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl35 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl35_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl35_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl36 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl36_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_bl36_get(swigCPtr);
      return ret;
    } 
  }

  public byte unknown_b37 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_b37_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_ASSOCPERSSUBENTMANAGER_unknown_b37_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Object_ASSOCPERSSUBENTMANAGER() : this(LibreDWGPINVOKE.new_Dwg_Object_ASSOCPERSSUBENTMANAGER(), true) {
  }

}
